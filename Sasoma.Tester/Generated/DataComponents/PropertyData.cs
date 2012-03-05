/**********************************************************************/
/* FrameworkGen (written by Lee Crowe)                                */
/* Elency Solutions - http://www.elencysolutions.co.uk                */
/*                                                                    */
/* This file was automatically generated using FrameworkGen v4.1.0.0. */
/* Any manual changes to this file will be overwritten.               */
/*                                                                    */
/* Date Generated: 16/02/2012 04:42:39                                */
/*                                                                    */
/**********************************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Microdata.DataComponents
{
	using BusinessComponents.Entities;
	using Helpers;

	/// <summary>
	/// Data Access Class for table 'Properties'.
	/// </summary>
	public sealed partial class PropertyData : DataAccessBase, IPropertyData, IDisposable
	{

		#region Members and Constants

		private bool _disposed;

		private const string TABLE_NAME = "Properties";
		private const string APP_SETTINGS_KEY_PREFIX = "Microdata";

		#endregion Members and Constants

		#region Constructor

		/// <summary>
		/// Default constructor.
		/// </summary>
		/// <exception cref="DataLayerException">DataLayerException.</exception>
		public PropertyData() : base(Databases.Microdata)
		{
			TableName = TABLE_NAME;
			AppSettingsKeyPrefix = APP_SETTINGS_KEY_PREFIX;

			DataAdapter.TableMappings.AddRange(new DataTableMapping[] {
				new DataTableMapping("Table", TableName, new DataColumnMapping[] {
					new DataColumnMapping("PropertyId", "PropertyId"),
					new DataColumnMapping("Comment", "Comment"),
					new DataColumnMapping("Comment_Plain", "Comment_Plain"),
					new DataColumnMapping("Domains", "Domains"),
					new DataColumnMapping("Id", "Id"),
					new DataColumnMapping("Label", "Label"),
					new DataColumnMapping("Ranges", "Ranges")})});
		}

		#endregion Constructor

		#region Public methods

		#endregion Public methods

		#region Protected methods


		/// <summary>
		/// Builds a typed property entity collection.
		/// </summary>
		/// <returns>Returns a populated 'Properties' entity object collection.</returns>
		/// <exception cref="DataLayerException">DataLayerException.</exception>
		protected override IEntities BuildEntities()
		{
			Properties properties = new Properties();
			bool originalAddEntityIfAlreadyExists = properties.AddEntityIfAlreadyExists;
			bool originalFireEvents = properties.FireEvents;
			IDataReader reader = DataReader;

			try
			{
				properties.AddEntityIfAlreadyExists = true;
				properties.FireEvents = false;

				// Get the ordinal values of each column in the result set
				List<string> columns = GetReaderColumns(reader);
				int propertyIdOrdinal = columns.IndexOf("PropertyId");
				int commentOrdinal = columns.IndexOf("Comment");
				int comment_PlainOrdinal = columns.IndexOf("Comment_Plain");
				int domainsOrdinal = columns.IndexOf("Domains");
				int idOrdinal = columns.IndexOf("Id");
				int labelOrdinal = columns.IndexOf("Label");
				int rangesOrdinal = columns.IndexOf("Ranges");

				// Iterate every record in the result set
				while (reader.Read())
				{
					Property property = new Property();
					property.SetExisting();

					// If column PropertyId exists in the result set get its value
					if (propertyIdOrdinal != -1)
						property.PropertyId = reader.GetInt32(propertyIdOrdinal);

					// If column Comment exists in the result set get its value
					if (commentOrdinal != -1)
						property.Comment = reader.GetString(commentOrdinal);

					// If column Comment_Plain exists in the result set get its value
					if (comment_PlainOrdinal != -1)
						property.Comment_Plain = reader.GetString(comment_PlainOrdinal);

					// If column Domains exists in the result set get its value
					if (domainsOrdinal != -1)
					{
						if (!reader.IsDBNull(domainsOrdinal))
							property.Domains = reader.GetString(domainsOrdinal);
					}

					// If column Id exists in the result set get its value
					if (idOrdinal != -1)
						property.Id = reader.GetString(idOrdinal);

					// If column Label exists in the result set get its value
					if (labelOrdinal != -1)
						property.Label = reader.GetString(labelOrdinal);

					// If column Ranges exists in the result set get its value
					if (rangesOrdinal != -1)
					{
						if (!reader.IsDBNull(rangesOrdinal))
							property.Ranges = reader.GetString(rangesOrdinal);
					}

					property.HasChanges = false;
					properties.Add(property);
				}
			}
			catch (Exception ex)
			{
				HandleException(ex, ex.Message + " An error occurred while trying to populate the 'Property' entity object from the reader.");
			}
			finally
			{
				properties.AddEntityIfAlreadyExists = originalAddEntityIfAlreadyExists;
				properties.FireEvents = originalFireEvents;
			}

			return properties;
		}


		#endregion Protected methods

		#region IDisposable members

		/// <summary>
		/// Disposes of the current class.
		/// </summary>
		public override void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Disposes all managed and unmanaged resources in this class.
		/// </summary>
		/// <param name="disposing">True if disposing, otherwise false.</param>
		private void Dispose(bool disposing)
		{
			// Check to see if dispose has already been called
			if (!_disposed)
				return;

			ReleaseCommand();
			ReleaseCommand(DeleteCommand);
			ReleaseCommand(InsertCommand);
			ReleaseCommand(UpdateCommand);
			ReleaseConnection();
			ReleaseDataAdapter();
			_disposed = true;
		}

		#endregion IDisposable members

	}
}
