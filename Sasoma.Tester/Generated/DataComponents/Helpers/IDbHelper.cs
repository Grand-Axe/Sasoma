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

namespace Microdata.DataComponents.Helpers
{

	/// <summary>
	/// Interface for all Database Helper classes.
	/// </summary>
    interface IDbHelper
    {
        
        /// <summary>
		/// Gets or sets the command timeout.
		/// </summary>
        int CommandTimeout { get; set; }
        
        /// <summary>
		/// Creates a new connection.
		/// </summary>
		/// <param name="connectionString">Connection string.</param>
		/// <returns>DBConnection.</returns>
		/// <exception cref="DbHelperException">DbHelperException.</exception>
        DbConnection CreateConnection(string connectionString);

		/// <summary>
		/// Creates a new Data Adapter.
		/// </summary>
		/// <returns>DbDataAdapter.</returns>
        DbDataAdapter CreateDataAdapter();
        
        /// <summary>
		/// Creates a new command.
		/// </summary>
		/// <param name="commandText">Command text.</param>
		/// <param name="connection">DbConnection.</param>
        /// <param name="transaction">DbTransaction.</param>
		/// <returns>DbCommand.</returns>
		/// <exception cref="DbHelperException">DbHelperException.</exception>
        DbCommand CreateCommand(string commandText, DbConnection connection, DbTransaction transaction);

		/// <summary>
		/// Creates a new stored procedure command.
		/// </summary>
		/// <param name="procedureName">Procedure name.</param>
		/// <param name="connection">DbConnection.</param>
        /// <param name="transaction">DbTransaction.</param>
		/// <returns>DbCommand.</returns>
		/// <exception cref="DbHelperException">DbHelperException.</exception>
        DbCommand CreateStoredProcedureCommand(string procedureName, DbConnection connection, DbTransaction transaction);

		/// <summary>
        /// Adds a return value parameter to the command object.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="dbType">DbType.</param>
        void AddReturnValueParameter(DbCommand command, string parameterName, DbType dbType);
        
        /// <summary>
        /// Adds a return value parameter to the command object.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        void AddReturnValueParameter(DbCommand command, string parameterName, DbType dbType, int size);

        /// <summary>
        /// Adds a return value parameter to the command object.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        void AddReturnValueParameter(DbCommand command, string parameterName, DbType dbType, byte precision, byte scale);
        
		/// <summary>
		/// Adds an input parameter.
		/// </summary>
		/// <param name="command">DbCommand.</param>
		/// <param name="parameterName">Parameter name.</param>
		/// <param name="parameterValue">Parameter value.</param>
        void AddInParameter(DbCommand command, string parameterName, object parameterValue);

		/// <summary>
		/// Adds an input parameter.
		/// </summary>
		/// <param name="command">DbCommand.</param>
		/// <param name="parameterName">Parameter name.</param>
		/// <param name="parameterValue">Parameter value.</param>
		/// <param name="dbType">DbType.</param>
        void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType);
        
        /// <summary>
		/// Adds an input parameter.
		/// </summary>
		/// <param name="command">DbCommand.</param>
		/// <param name="parameterName">Parameter name.</param>
		/// <param name="parameterValue">Parameter value.</param>
		/// <param name="dbType">DbType.</param>
		/// <param name="sourceColumn">Source column.</param>
        void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, string sourceColumn);

		/// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, int size);

		/// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        /// <param name="sourceColumn">Source column.</param>
        void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, int size, string sourceColumn);

        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, byte precision, byte scale);

        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="sourceColumn">Source column.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, string sourceColumn, byte precision, byte scale);

		/// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        void AddOutParameter(DbCommand command, string parameterName, object parameterValue);

		/// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType);
        
        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="sourceColumn">Source column.</param>
        void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, string sourceColumn);

		/// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, int size);

		/// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        /// <param name="sourceColumn">Source column.</param>
        void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, int size, string sourceColumn);

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, byte precision, byte scale);

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="sourceColumn">Source column.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, string sourceColumn, byte precision, byte scale);
        
        /// <summary>
        /// Sets an output parameters value.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        void SetParameterValue(DbCommand command, string parameterName, object parameterValue);

		/// <summary>
        /// Gets a parameter value.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <returns>Parameter value as an object.</returns>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        object GetParameterValue(DbCommand command, string parameterName);
        
        /// <summary>
        /// Checks whether a parameter exists.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <returns>True if found, otherwise false.</returns>
        bool CheckParameterExists(DbCommand command, string parameterName);

		/// <summary>
        /// Creates a new transaction.
        /// </summary>
        /// <param name="connection">DbConnection.</param>
        /// <returns>DbTransaction.</returns>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        DbTransaction CreateTransaction(DbConnection connection);

        /// <summary>
        /// Creates a new transaction.
        /// </summary>
        /// <param name="connection">DbConnection.</param>
        /// <param name="transactionName">The name of the transaction.</param>
        /// <returns>DbTransaction.</returns>
        /// <exception cref="DataLayerException">DbHelperException.</exception>
        DbTransaction CreateTransaction(DbConnection connection, string transactionName);

        /// <summary>
        /// Creates a new transaction.
        /// </summary>
        /// <param name="connection">DbConnection.</param>
        /// <param name="isolationLevel">The isolation level to use.</param>
        /// <returns>DbTransaction.</returns>
        /// <exception cref="DataLayerException">DbHelperException.</exception>
        DbTransaction CreateTransaction(DbConnection connection, IsolationLevel isolationLevel);

        /// <summary>
        /// Creates a new transaction.
        /// </summary>
        /// <param name="connection">DbConnection.</param>
        /// <param name="isolationLevel">The isolation level to use.</param>
        /// <param name="transactionName">The name of the transaction.</param>
        /// <returns>DbTransaction.</returns>
        /// <exception cref="DataLayerException">DbHelperException.</exception>
        DbTransaction CreateTransaction(DbConnection connection, IsolationLevel? isolationLevel, string transactionName);

    }
}
