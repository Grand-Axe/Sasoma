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
using System.Data;
using System.Data.Common;

namespace Microdata.DataComponents
{
    using BusinessComponents.Entities;

    /// <summary>
    /// Interface for data access base class
    /// </summary>
    public partial interface IDataAccessBase
    {
        /// <summary>
        /// Commits a transaction.
        /// </summary>
        /// <param name="transaction">DbTransaction.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        void CommitTransaction(DbTransaction transaction);

        /// <summary>
        /// Dispose method.
        /// </summary>
        void Dispose();

        /// <summary>
        /// Disposes of a transaction.
        /// </summary>
        /// <param name="transaction">DbTransaction.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        void DisposeOfTransaction(DbTransaction transaction);

        /// <summary>
        /// Gets a new transaction.
        /// </summary>
        /// <param name="isolationLevel">The isolation level to use.</param>
        /// <returns>DbTransaction.</returns>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        DbTransaction CreateTransaction(IsolationLevel isolationLevel);

        /// <summary>
        /// Gets a new transaction.
        /// </summary>
        /// <param name="transactionName">The name of the transaction.</param>
        /// <returns>DbTransaction.</returns>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        DbTransaction CreateTransaction(string transactionName);

        /// <summary>
        /// Gets a new transaction.
        /// </summary>
        /// <returns>DbTransaction.</returns>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        DbTransaction CreateTransaction();

        /// <summary>
        /// Gets a new transaction.
        /// </summary>
        /// <param name="isolationLevel">The isolation level to use.</param>
        /// <param name="transactionName">The name of the transaction.</param>
        /// <returns>DbTransaction.</returns>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        DbTransaction CreateTransaction(IsolationLevel? isolationLevel, string transactionName);

        /// <summary>
        /// Rollsback a transactoin.
        /// </summary>
        /// <param name="transaction">DbTransaction.</param>
        /// <exception cref="DataLayerException">DataLayerException</exception>
        void RollbackTransaction(DbTransaction transaction);

        /// <summary>
        /// Updates records in the current table using transactions.
        /// </summary>
        /// <param name="table">Data Table.</param>
        /// <param name="transaction">DbTransaction.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        void Save(DataTable table, DbTransaction transaction);

        /// <summary>
        /// Updates records in the current table.
        /// </summary>
        /// <param name="rows">Collection of data rows</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        void Save(DataRow[] rows);

        /// <summary>
        /// Updates records in the current table using transactions.
        /// </summary>
        /// <param name="rows">Collection of data rows</param>
        /// <param name="transaction">DbTransaction.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        void Save(DataRow[] rows, DbTransaction transaction);

        /// <summary>
        /// Updates records in the current table.
        /// </summary>
        /// <param name="table">Data Table.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        void Save(DataTable table);

        /// <summary>
        /// Inserts, updates and deletes rows in a table
        /// </summary>
        /// <param name="entities">Entity object collection to update in the database.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        void Save(IEntities entities);

        /// <summary>
        /// Inserts, updates and deletes a row in a table using a transaction if required.
        /// </summary>
        /// <param name="entity">The entity object to update in the database.</param>
        /// <param name="transaction">DbTransaction.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        void Save(IEntity entity, DbTransaction transaction);

        /// <summary>
        /// Inserts, updates and deletes a row in a table.
        /// </summary>
        /// <param name="entity">The entity object to update in the database.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        void Save(IEntity entity);

        /// <summary>
        /// Inserts, updates and deletes rows in a table using a transaction if required.
        /// </summary>
        /// <param name="entities">The entity object collection to update in the database.</param>
        /// <param name="transaction">DbTransaction.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        void Save(IEntities entities, DbTransaction transaction);
    }
}
