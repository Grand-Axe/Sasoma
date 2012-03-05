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
	/// Data Access Class for table 'Types'.
	/// </summary>
	public sealed partial class TypeData : DataAccessBase, ITypeData, IDisposable
	{

		#region Members and Constants

		private bool _disposed;

		private const string TABLE_NAME = "Types";
		private const string APP_SETTINGS_KEY_PREFIX = "Microdata";

		#endregion Members and Constants

		#region Constructor

		/// <summary>
		/// Default constructor.
		/// </summary>
		/// <exception cref="DataLayerException">DataLayerException.</exception>
		public TypeData() : base(Databases.Microdata)
		{
			TableName = TABLE_NAME;
			AppSettingsKeyPrefix = APP_SETTINGS_KEY_PREFIX;

			DataAdapter.TableMappings.AddRange(new DataTableMapping[] {
				new DataTableMapping("Table", TableName, new DataColumnMapping[] {
					new DataColumnMapping("TypeId", "TypeId"),
					new DataColumnMapping("Ancestors", "Ancestors"),
					new DataColumnMapping("Comment", "Comment"),
					new DataColumnMapping("Comment_Plain", "Comment_Plain"),
					new DataColumnMapping("Id", "Id"),
					new DataColumnMapping("Instances", "Instances"),
					new DataColumnMapping("Label", "Label"),
					new DataColumnMapping("Properties", "Properties"),
					new DataColumnMapping("Specific_Properties", "Specific_Properties"),
					new DataColumnMapping("SubTypes", "SubTypes"),
					new DataColumnMapping("SuperTypes", "SuperTypes"),
					new DataColumnMapping("Url", "Url"),
					new DataColumnMapping("IsDataType", "IsDataType")})});
		}

		#endregion Constructor

		#region Public methods

		#endregion Public methods

		#region Protected methods


		/// <summary>
		/// Builds a typed type entity collection.
		/// </summary>
		/// <returns>Returns a populated 'Types' entity object collection.</returns>
		/// <exception cref="DataLayerException">DataLayerException.</exception>
		protected override IEntities BuildEntities()
		{
			Types types = new Types();
			bool originalAddEntityIfAlreadyExists = types.AddEntityIfAlreadyExists;
			bool originalFireEvents = types.FireEvents;
			IDataReader reader = DataReader;

			try
			{
				types.AddEntityIfAlreadyExists = true;
				types.FireEvents = false;

				// Get the ordinal values of each column in the result set
				List<string> columns = GetReaderColumns(reader);
				int typeIdOrdinal = columns.IndexOf("TypeId");
				int ancestorsOrdinal = columns.IndexOf("Ancestors");
				int commentOrdinal = columns.IndexOf("Comment");
				int comment_PlainOrdinal = columns.IndexOf("Comment_Plain");
				int idOrdinal = columns.IndexOf("Id");
				int instancesOrdinal = columns.IndexOf("Instances");
				int labelOrdinal = columns.IndexOf("Label");
				int propertiesOrdinal = columns.IndexOf("Properties");
				int specific_PropertiesOrdinal = columns.IndexOf("Specific_Properties");
				int subTypesOrdinal = columns.IndexOf("SubTypes");
				int superTypesOrdinal = columns.IndexOf("SuperTypes");
				int urlOrdinal = columns.IndexOf("Url");
				int isDataTypeOrdinal = columns.IndexOf("IsDataType");

				// Iterate every record in the result set
				while (reader.Read())
				{
					Type type = new Type();
					type.SetExisting();

					// If column TypeId exists in the result set get its value
					if (typeIdOrdinal != -1)
						type.TypeId = reader.GetInt32(typeIdOrdinal);

					// If column Ancestors exists in the result set get its value
					if (ancestorsOrdinal != -1)
					{
						if (!reader.IsDBNull(ancestorsOrdinal))
							type.Ancestors = reader.GetString(ancestorsOrdinal);
					}

					// If column Comment exists in the result set get its value
					if (commentOrdinal != -1)
						type.Comment = reader.GetString(commentOrdinal);

					// If column Comment_Plain exists in the result set get its value
					if (comment_PlainOrdinal != -1)
						type.Comment_Plain = reader.GetString(comment_PlainOrdinal);

					// If column Id exists in the result set get its value
					if (idOrdinal != -1)
						type.Id = reader.GetString(idOrdinal);

					// If column Instances exists in the result set get its value
					if (instancesOrdinal != -1)
					{
						if (!reader.IsDBNull(instancesOrdinal))
							type.Instances = reader.GetString(instancesOrdinal);
					}

					// If column Label exists in the result set get its value
					if (labelOrdinal != -1)
						type.Label = reader.GetString(labelOrdinal);

					// If column Properties exists in the result set get its value
					if (propertiesOrdinal != -1)
					{
						if (!reader.IsDBNull(propertiesOrdinal))
							type.Properties = reader.GetString(propertiesOrdinal);
					}

					// If column Specific_Properties exists in the result set get its value
					if (specific_PropertiesOrdinal != -1)
					{
						if (!reader.IsDBNull(specific_PropertiesOrdinal))
							type.Specific_Properties = reader.GetString(specific_PropertiesOrdinal);
					}

					// If column SubTypes exists in the result set get its value
					if (subTypesOrdinal != -1)
					{
						if (!reader.IsDBNull(subTypesOrdinal))
							type.SubTypes = reader.GetString(subTypesOrdinal);
					}

					// If column SuperTypes exists in the result set get its value
					if (superTypesOrdinal != -1)
					{
						if (!reader.IsDBNull(superTypesOrdinal))
							type.SuperTypes = reader.GetString(superTypesOrdinal);
					}

					// If column Url exists in the result set get its value
					if (urlOrdinal != -1)
						type.Url = reader.GetString(urlOrdinal);

					// If column IsDataType exists in the result set get its value
					if (isDataTypeOrdinal != -1)
					{
						if (!reader.IsDBNull(isDataTypeOrdinal))
							type.IsDataType = reader.GetBoolean(isDataTypeOrdinal);
					}

					type.HasChanges = false;
					types.Add(type);
				}
			}
			catch (Exception ex)
			{
				HandleException(ex, ex.Message + " An error occurred while trying to populate the 'Type' entity object from the reader.");
			}
			finally
			{
				types.AddEntityIfAlreadyExists = originalAddEntityIfAlreadyExists;
				types.FireEvents = originalFireEvents;
			}

			return types;
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
