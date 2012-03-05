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
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Reflection;

namespace Microdata.BusinessComponents
{
	using Entities;
	using DataComponents;
	
	/// <summary>
	/// Base class for all business objects.
	/// </summary>
	public abstract class BusinessBase
    {
        
        #region Members

        private DbTransaction _transaction;
        private IsolationLevel _isolationLevel = IsolationLevel.ReadCommitted;
        private IDataAccessBase _dataObject;
        private bool _createdTransaction;
        private string _appSettingsKeyPrefix;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        protected BusinessBase()
        {
        }

        /// <summary>
        /// Overriden contructor
        /// </summary>
        /// <param name="transaction">DbTransaction.</param>
        /// <param name="isolationLevel">IsolationLevel</param>
        protected BusinessBase(DbTransaction transaction, IsolationLevel? isolationLevel)
        {
            _transaction = transaction;
            
            if (isolationLevel.HasValue)
				_isolationLevel = isolationLevel.Value;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
		/// Handles an exception if one has occurred.
		/// </summary>
		/// <param name="exception">Exception that occurred.</param>
		/// <param name="message">Exception message.</param>
		/// <exception cref="BusinessLayerException">BusinessLayerException.</exception>
		protected void HandleException(Exception exception, string message)
		{
			BusinessLayerException businessLayerException = new BusinessLayerException(message, exception);
            throw businessLayerException;
		}
		
		/// <summary>
		/// Gets a transaction.
		/// </summary>
        /// <param name="dataObject">Data component.</param>
        /// <param name="transactionName">Transaction name.</param>
		/// <returns>True if a transaction was created, otherwise false.</returns>
		protected bool CreateTransaction(IDataAccessBase dataObject, string transactionName)
		{
			if (Transaction != null)
				return false;

            DataObject = dataObject;
			CreatedTransaction = false;
			Transaction = dataObject.CreateTransaction(IsolationLevel, transactionName);
			CreatedTransaction = true;
	
			return CreatedTransaction;
		}

        /// <summary>
        /// Disposes of a transaction.
        /// </summary>
        /// <exception cref="BusinessLayerException">DataLayerException.</exception>
        protected void DisposeOfTransaction()
        {
            try
            {
                if (Transaction != null && CreatedTransaction)
                {
                    if (Transaction.Connection != null && Transaction.Connection.State != ConnectionState.Closed)
                        Transaction.Connection.Close();
                    
                    Transaction.Dispose();
                    Transaction = null;
                }
            }
            catch (Exception ex)
            {
                HandleException(ex, ex.Message + " An unexpected error occured while trying to dispose of the transaction.");
            }
        }
        
        /// <summary>
        /// Disposes of a data object.
        /// </summary>
        /// <param name="dataObject">Data object.</param>
        /// <param name="rollbackTransaction">Indicates whether a transaction should be rolled back.</param>
        /// <param name="canRollbackTransaction">Indicates whether the transaction can be rolled back.</param>
        protected void DisposeOfDataObject(IDataAccessBase dataObject, bool rollbackTransaction, bool canRollbackTransaction)
        {
            if (dataObject != null)
            {
                try
                {
                    if (canRollbackTransaction && Transaction != null && rollbackTransaction)
                        dataObject.RollbackTransaction(Transaction);

                    if (canRollbackTransaction)
                        dataObject.DisposeOfTransaction(Transaction);
                }
                catch (Exception ex)
                {
                    HandleException(ex, ex.Message + " An unexpected exception occurred while trying to dispose of the transaction.");
                }
                finally
                {
                    dataObject.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Stores Pre save values for entities
        /// </summary>
        /// <param name="entities">Entity collection</param>
        protected void StorePreSaveValuesRecursive(IEntities entities)
        {
            entities.StorePreSaveValues();

            foreach (IEntity entity in entities)
            {
				if (entity == null)
					continue;
					
                PropertyInfo[] properties = entity.GetType().GetProperties();
                foreach (PropertyInfo propertyInfo in properties)
                {
                    if (propertyInfo.GetValue(entity, null) is IEntities)
                        StorePreSaveValuesRecursive((IEntities)propertyInfo.GetValue(entity, null));
                }
            }
        }

        /// <summary>
        /// Restores Pre save values for entities
        /// </summary>
        /// <param name="entities">Entity collection</param>
        protected void RestorePreSaveValuesRecursive(IEntities entities)
        {
            entities.RestorePreSaveValues();

            foreach (IEntity entity in entities)
            {
                if (entity == null)
                    continue;

                PropertyInfo[] properties = entity.GetType().GetProperties();
                foreach (PropertyInfo propertyInfo in properties)
                {
                    if (propertyInfo.GetValue(entity, null) is IEntities)
                        RestorePreSaveValuesRecursive((IEntities)propertyInfo.GetValue(entity, null));
                }
            }
        }
        
        /// <summary>
        /// Saves children of the current entity.
        /// </summary>
        /// <param name="entity">Entity object for which children need saving.</param>
        /// <param name="transactional">True if transactions are required, otherwise false.</param>
        /// <param name="depth">The depth of child entities that need loading.</param>
        /// <param name="entitiesToExclude">Entities to exclude.</param>
        /// <exception cref="BusinessRulesValidationException">BusinessRulesValidationException.</exception>
        protected virtual void SaveChildren(IEntity entity, bool transactional, int depth, params Type[] entitiesToExclude)
        {
        }

        /// <summary>
        /// Stores entity values before a save is performed.
        /// </summary>
        /// <param name="entity">Entity</param>
        protected virtual void StorePreSaveValues(IEntity entity)
        {
        }

        /// <summary>
        /// Restores entity values after a save has failed.
        /// </summary>
        /// <param name="entity">Entity</param>
        protected virtual void RestorePreSaveValues(IEntity entity)
        {
        }
        
        /// <summary>
        /// Validates the entity against its business rules.
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>True if valid, otherwise false.</returns>
        /// <exception cref="BusinessRulesValidationException">BusinessRulesValidationException</exception>
        protected virtual bool ValidateEntity(IEntity entity)
        {
			return true;
        }
        
        /// <summary>
        /// Validates the collection against its business rules.
        /// </summary>
        /// <param name="entities">Entities</param>
        /// <returns>True if valid, otherwise false.</returns>
        /// <exception cref="BusinessRulesValidationException">BusinessRulesValidationException</exception>
        protected virtual bool ValidateEntities(IEntities entities)
        {
			return true;
        }
        
        /// <summary>
        /// Validates the table against its business rules.
        /// </summary>
        /// <param name="table">DataTable</param>
        /// <returns>True if valid, otherwise false.</returns>
        /// <exception cref="BusinessRulesValidationException">BusinessRulesValidationException</exception>
        protected virtual bool ValidateDataTable(DataTable table)
        {
			return true;
        }

        /// <summary>
        /// Inserts, updates and deletes a row in a table using a transaction if required, child entities can also be saved.
        /// </summary>
        /// <param name="dataObject">The data object.</param>
        /// <param name="entity">The entity object to update in the database.</param>
        /// <param name="transactional">True if transactions are required, otherwise false.</param>
        /// <exception cref="BusinessLayerException">BusinessLayerException.</exception>
        /// <exception cref="BusinessRulesValidationException">BusinessRulesValidationException</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException</exception>
        protected void SaveEntity(IDataAccessBase dataObject, IEntity entity, bool transactional)
        {
            SaveEntity(dataObject, entity, transactional, 0, new Type[]{});
        }
        
        /// <summary>
        /// Inserts, updates and deletes a row in a table using a transaction if required, child entities can also be saved.
        /// </summary>
        /// <param name="dataObject">The data object.</param>
        /// <param name="entity">The entity object to update in the database.</param>
        /// <param name="transactional">True if transactions are required, otherwise false.</param>
        /// <param name="depth">The depth of child entities that need saving.</param>
        /// <exception cref="BusinessLayerException">BusinessLayerException.</exception>
        /// <exception cref="BusinessRulesValidationException">BusinessRulesValidationException</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException</exception>
        protected void SaveEntity(IDataAccessBase dataObject, IEntity entity, bool transactional, int depth)
        {
			SaveEntity(dataObject, entity, transactional, depth, new Type[]{});
        }

        /// <summary>
        /// Inserts, updates and deletes a row in a table using a transaction if required, child entities can also be saved.
        /// </summary>
        /// <param name="dataObject">The data object.</param>
        /// <param name="entity">The entity object to update in the database.</param>
        /// <param name="transactional">True if transactions are required, otherwise false.</param>
        /// <param name="depth">The depth of child entities that need saving.</param>
        /// <param name="entitiesToExclude">Entities to exclude.</param>
        /// <exception cref="BusinessLayerException">BusinessLayerException.</exception>
        /// <exception cref="BusinessRulesValidationException">BusinessRulesValidationException</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException</exception>
        protected void SaveEntity(IDataAccessBase dataObject, IEntity entity, bool transactional, int depth, params Type[] entitiesToExclude)
        {
            bool rollbackTransaction = false;
            bool createdTransaction = false;

            if (entity == null || (!entity.HasChanges && depth == 0) || dataObject == null)
                return;

            try
            {
                if (!ValidateEntity(entity))
                    return;

                if (transactional)
                {
                    createdTransaction = CreateTransaction(dataObject, "Update" + entity.GetType().Name);

                    if (createdTransaction)
                        StorePreSaveValues(entity);

                    dataObject.Save(entity, Transaction);
                    SaveChildren(entity, true, depth, entitiesToExclude);

                    if (createdTransaction)
                        dataObject.CommitTransaction(Transaction);
                }
                else
                {
                    dataObject.Save(entity);
                    SaveChildren(entity, false, depth, entitiesToExclude);
                }
            }
            catch (Exception ex)
            {
                if (createdTransaction)
                    rollbackTransaction = true;

                if (ex is DBConcurrencyException || ex is BusinessRulesValidationException)
                    throw;

                HandleException(ex, ex.Message + " An unexpected exception occurred while trying to save an " + entity.GetType().Name + " entity.");
            }
            finally
            {
                if (rollbackTransaction && transactional)
                    RestorePreSaveValues(entity);

                DisposeOfDataObject(dataObject, rollbackTransaction, createdTransaction);
            }
        }

        /// <summary>
        /// Inserts, updates and deletes rows in a table using transactions if required.
        /// </summary>
        /// <param name="dataObject">The data object.</param>
        /// <param name="entities">The entities collection to update in the database.</param>
        /// <param name="transactional">Indicates whether to use transactions or not.</param>
        /// <exception cref="BusinessLayerException">BusinessLayerException.</exception>
        /// <exception cref="BusinessRulesValidationException">BusinessRulesValidationException</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException</exception>
        protected void SaveEntities(IDataAccessBase dataObject, IEntities entities, bool transactional)
        {
            bool rollbackTransaction = false;
            bool createdTransaction = false;

            try
            {
                if (entities == null || dataObject == null || entities.Count == 0 || !entities.HasChanges || !ValidateEntities(entities))
                    return;

                // if we are using transactions update the table using transaction
                if (transactional)
                {
                    entities.StorePreSaveValues();
                    createdTransaction = CreateTransaction(dataObject, "Update" + entities.GetType().Name);
                    dataObject.Save(entities, Transaction);
                    if (createdTransaction)
                        dataObject.CommitTransaction(Transaction);
                }
                else
                    dataObject.Save(entities);

                entities.RemoveDeletedEntities();
            }
            catch (Exception ex)
            {
                if (createdTransaction)
                    rollbackTransaction = true;

                if (ex is DBConcurrencyException || ex is BusinessRulesValidationException)
                    throw;

                HandleException(ex, ex.Message + " An unexpected exception occurred while trying to save " + entities.GetType().Name + " entities.");
            }
            finally
            {
                if (rollbackTransaction && transactional)
                    entities.RestorePreSaveValues();

                DisposeOfDataObject(dataObject, rollbackTransaction, createdTransaction);
            }
        }

        /// <summary>
        /// Inserts, updates and deletes a row in table, using a transaction if required.
        /// </summary>
        /// <param name="dataObject">The data object.</param>
        /// <param name="table">Table to update.</param>
        /// <param name="transactional">Indicates whether to use transactions or not.</param>
        /// <exception cref="BusinessLayerException">BusinessLayerException.</exception>
        /// <exception cref="BusinessRulesValidationException">BusinessRulesValidationException</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException</exception>
        protected void SaveDataTable(IDataAccessBase dataObject, DataTable table, bool transactional)
        {
            bool rollbackTransaction = false;
            bool createdTransaction = false;

            try
            {
                if (table == null || table.Rows.Count == 0 || !ValidateDataTable(table))
                    return;

                // if we are using transactions, update table using transaction, otherwise update without one
                if (transactional)
                {
                    createdTransaction = CreateTransaction(dataObject, "Update" + table.TableName.Trim());
                    dataObject.Save(table, Transaction);
                    dataObject.CommitTransaction(Transaction);
                }
                else
                    dataObject.Save(table);
            }
            catch (Exception ex)
            {
                if (createdTransaction)
                    rollbackTransaction = true;

                if (ex is DBConcurrencyException || ex is BusinessRulesValidationException)
                    throw;

                HandleException(ex, ex.Message + " An unexpected exception occurred while trying to save to the database.");
            }
            finally
            {
                DisposeOfDataObject(dataObject, rollbackTransaction, createdTransaction);
            }
        }
		
		#endregion Methods

        #region Properties

        /// <summary>
        /// Gets or sets a transaction for the business object
        /// </summary>
        protected DbTransaction Transaction
        {
            get
            {
                return _transaction;
            }
            set
            {
                _transaction = value;
            }
        }

        /// <summary>
        /// Gets or sets the transaction isolation level to use
        /// </summary>
        public IsolationLevel IsolationLevel
        {
            get
            {
                return _isolationLevel;
            }
            set
            {
                _isolationLevel = value;
            }
        }

        /// <summary>
        /// Gets or sets whether this business object created the current transaction.
        /// </summary>
        protected bool CreatedTransaction
        {
            get
            {
                return _createdTransaction;
            }
            set
            {
                _createdTransaction = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the data object
        /// </summary>
        protected IDataAccessBase DataObject
        {
            get
            {
                return _dataObject;
            }
            set
            {
                _dataObject = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the app settings key prefix
        /// </summary>
        protected string AppSettingsKeyPrefix
        {
			get
			{
				return string.IsNullOrEmpty(_appSettingsKeyPrefix) ? string.Empty : string.Concat(_appSettingsKeyPrefix, "_");
			}
			set
			{
				_appSettingsKeyPrefix = value;
			}
        }

        #endregion Properties

    }
}
