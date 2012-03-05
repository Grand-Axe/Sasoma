/**********************************************************************/
/* FrameworkGen (written by Lee Crowe)                                */
/* Elency Solutions - http://www.elencysolutions.co.uk                */
/*                                                                    */
/* This file was automatically generated using FrameworkGen v4.1.0.0. */
/* Any manual changes to this file will be overwritten.               */
/*                                                                    */
/* Date Generated: 16/02/2012 04:42:40                                */
/*                                                                    */
/**********************************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Microdata.BusinessComponents
{
	using Entities;
	using DataComponents;

	/// <summary>
	/// Business Rules class for table 'Types'.
	/// </summary>
	public sealed partial class TypeManager : BusinessBase, IDisposable
	{

		#region Members and constants

		private bool _disposed;
		private const string APP_SETTINGS_KEY_PREFIX = "Microdata";

		#endregion Members and constants

		#region Constructors

		/// <summary>
		/// Default constructor
		/// </summary>
		public TypeManager()
		{
			AppSettingsKeyPrefix = APP_SETTINGS_KEY_PREFIX;
		}

		/// <summary>
		/// Overriden constructor
		/// </summary>
		/// <param name="cachingEnabled">Specifies whether caching is enabled</param>
		public TypeManager(bool cachingEnabled)
		{
			AppSettingsKeyPrefix = APP_SETTINGS_KEY_PREFIX;
		}

		/// <summary>
		/// Overriden constructor
		/// </summary>
		/// <param name="isolationLevel">IsolationLevel</param>
		public TypeManager(IsolationLevel isolationLevel) : this(null, isolationLevel)
		{
			AppSettingsKeyPrefix = APP_SETTINGS_KEY_PREFIX;
		}

		/// <summary>
		/// Overriden constructor
		/// </summary>
		/// <param name="isolationLevel">IsolationLevel</param>
		/// <param name="cachingEnabled">Specifies whether caching is enabled</param>
		public TypeManager(IsolationLevel isolationLevel, bool cachingEnabled) : this(null, isolationLevel)
		{
			AppSettingsKeyPrefix = APP_SETTINGS_KEY_PREFIX;
		}

		/// <summary>
		/// Overriden constructor
		/// </summary>
		/// <param name="transaction">DbTransaction</param>
		internal TypeManager(DbTransaction transaction) : this(transaction, null)
		{
			AppSettingsKeyPrefix = APP_SETTINGS_KEY_PREFIX;
		}

		/// <summary>
		/// Overriden constructor
		/// </summary>
		/// <param name="transaction">DbTransaction</param>
		/// <param name="isolationLevel">IsolationLevel</param>
		internal TypeManager(DbTransaction transaction, IsolationLevel? isolationLevel) : base(transaction, isolationLevel)
		{
			AppSettingsKeyPrefix = APP_SETTINGS_KEY_PREFIX;
		}

		#endregion Constructors

		#region Public methods

		/// <summary>
		/// Validates the entity against its business rules.
		/// </summary>
		/// <param name="type">Type.</param>
		/// <returns>True if valid, otherwise false.</returns>
		/// <exception cref="BusinessRulesValidationException">BusinessRulesValidationException</exception>
		public bool Validate(Type type)
		{
			return ValidateEntity(type);
		}

		/// <summary>
		/// Validates the entities collection against its business rules.
		/// </summary>
		/// <param name="types">Types.</param>
		/// <returns>True if valid, otherwise false.</returns>
		/// <exception cref="BusinessRulesValidationException">BusinessRulesValidationException</exception>
		public bool Validate(Types types)
		{
			return ValidateEntities(types);
		}

		#endregion Public methods

		#region Protected methods

		/// <summary>
		/// Stores entity values before a save is performed.
		/// </summary>
		/// <param name="entity">Type</param>
		protected override void StorePreSaveValues(IEntity entity)
		{
			Type type = entity as Type;
			type.StorePreSaveValues();
		}

		/// <summary>
		/// Restores entity values after a save has failed.
		/// </summary>
		/// <param name="entity">Type</param>
		protected override void RestorePreSaveValues(IEntity entity)
		{
			Type type = entity as Type;
			type.StorePreSaveValues();
		}

		#endregion Protected methods

		#region IDisposable members

		/// <summary>
		/// Disposes of the current class.
		/// </summary>
		public void Dispose()
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
			// Check to see if dispose has already been called.
			if (!_disposed)
				return;

			if (CreatedTransaction)
				DisposeOfTransaction();

			if (DataObject != null)
				DataObject.Dispose();

			_disposed = true;
		}

		#endregion IDisposable members

	}
}