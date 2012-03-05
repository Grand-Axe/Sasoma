using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Xml;

namespace Microdata.DataComponents
{
	/// <summary>
	/// Creates instances of data objects.
	/// </summary>
	public sealed class DataFactory
	{

		#region Members

		private string _appSettingsKeyPrefix = string.Empty;
		private static readonly Dictionary<string, Dictionary<string, string>> InversionOfControlMappings = new Dictionary<string, Dictionary<string, string>>();
		private static readonly List<FileSystemWatcher> InversionOfControlFileWatchers = new List<FileSystemWatcher>();
		private static readonly object _locker = new object();

		#endregion Members

		#region Properties

		/// <summary>
		/// Gets the data components inversion of control mapping file name
		/// </summary>
		private string DataComponentsInversionOfControlFilePath
		{
			get
			{
				if (ConfigurationManager.AppSettings[AppSettingsKeyPrefix + "Entities_DataComponentsInversionOfControlFilePath"] == null)
					return string.Empty;

				return ConfigurationManager.AppSettings[AppSettingsKeyPrefix + "Entities_DataComponentsInversionOfControlFilePath"].Trim();
			}
		}

		/// <summary>
		/// Gets the app settings key prefix
		/// </summary>
		private string AppSettingsKeyPrefix
		{
			get
			{
				return _appSettingsKeyPrefix;
			}
		}

		#endregion Properties

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="appSettingsKeyPrefix">App settings key prefix</param>
		public DataFactory(string appSettingsKeyPrefix)
		{
			_appSettingsKeyPrefix = appSettingsKeyPrefix;
		}

		#endregion Properties

		#region Methods

		/// <summary>
		/// Creates an instance of the PropertyData object that conforms to the IPropertyData interface.
		/// </summary>
		/// <returns>IPropertyData</returns>
		/// <exception cref="DataLayerException">DataLayerException</exception>
		public IPropertyData CreatePropertyData()
		{
			object dataComponent = CreateDataComponent(typeof(IPropertyData));
			return (dataComponent != null ? (IPropertyData)dataComponent : new PropertyData());
		}

		/// <summary>
		/// Creates an instance of the TypeData object that conforms to the ITypeData interface.
		/// </summary>
		/// <returns>ITypeData</returns>
		/// <exception cref="DataLayerException">DataLayerException</exception>
		public ITypeData CreateTypeData()
		{
			object dataComponent = CreateDataComponent(typeof(ITypeData));
			return (dataComponent != null ? (ITypeData)dataComponent : new TypeData());
		}

		/// <summary>
		/// Gets the inversion of control xml document
		/// </summary>
		/// <returns>XmlDocument</returns>
		private Dictionary<string, string> GetInversionOfControlMappings()
		{
			if (InversionOfControlMappings.ContainsKey(AppSettingsKeyPrefix))
				return InversionOfControlMappings[AppSettingsKeyPrefix];

			if (string.IsNullOrEmpty(DataComponentsInversionOfControlFilePath))
				return new Dictionary<string, string>();

			if (!File.Exists(DataComponentsInversionOfControlFilePath))
				throw new FileNotFoundException(string.Format("The file '{0}' does not exist.", DataComponentsInversionOfControlFilePath));

			lock (_locker)
			{
				// load the mappings from the xml file and populate the mappings dictionary
				XmlDocument inversionOfControlXmlDocument = new XmlDocument();
				inversionOfControlXmlDocument.Load(DataComponentsInversionOfControlFilePath);
				 Dictionary<string, string> inversionOfControlMappings = new Dictionary<string, string>();

				foreach (XmlNode node in inversionOfControlXmlDocument.SelectNodes("/dataComponentsInversionOfControl/dataComponent"))
				{
					if (node.Attributes["interfaceName"] == null || node.Attributes["fullTypeName"] == null)
						throw new InvalidDataException(string.Format("The structure in file '{0}' is incorrect.", DataComponentsInversionOfControlFilePath));

					string interfaceName = node.Attributes["interfaceName"].Value.Trim();
					string fullTypeName = node.Attributes["fullTypeName"].Value.Trim();

					if (string.IsNullOrEmpty(interfaceName) || string.IsNullOrEmpty(fullTypeName))
						continue;

					inversionOfControlMappings.Add(interfaceName, fullTypeName);
				}

				FileInfo fileInfo = new FileInfo(DataComponentsInversionOfControlFilePath);

				foreach (FileSystemWatcher watcher in InversionOfControlFileWatchers)
				{
					if (watcher.Path != fileInfo.Directory.FullName || watcher.Filter != fileInfo.Name)
						continue;

					InversionOfControlFileWatchers.Remove(watcher);
					break;
				}

				FileSystemWatcher fileWatcher = new FileSystemWatcher(fileInfo.Directory.FullName, fileInfo.Name);
				fileWatcher.EnableRaisingEvents = true;
				fileWatcher.Changed += InversionOfControlFileChanged;
				InversionOfControlFileWatchers.Add(fileWatcher);
				InversionOfControlMappings.Add(AppSettingsKeyPrefix, inversionOfControlMappings);
			}

			return InversionOfControlMappings[AppSettingsKeyPrefix];
		}

		/// <summary>
		/// Fired when the inversion of control file changes, this forces the mappings to get refreshed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void InversionOfControlFileChanged(object sender, FileSystemEventArgs e)
		{
			InversionOfControlFileWatchers.Clear();
			InversionOfControlMappings.Clear();
			GetInversionOfControlMappings();
		}

		/// <summary>
		/// Creates a database component based on the supplied interface name
		/// </summary>
		/// <param name="interfaceType">Interface type</param>
		private object CreateDataComponent(Type interfaceType)
		{
			if (interfaceType == null)
				return null;

			Dictionary<string, string> inversionOfControlMappings = GetInversionOfControlMappings();
			string interfaceName = interfaceType.Name;

			if (!inversionOfControlMappings.ContainsKey(interfaceName))
				return null;

			string fullTypeName = inversionOfControlMappings[interfaceName];

			if (string.IsNullOrEmpty(fullTypeName))
				return null;

			Type type = Type.GetType(fullTypeName);
			return Activator.CreateInstance(type);
		}

		#endregion Properties

	}
}
