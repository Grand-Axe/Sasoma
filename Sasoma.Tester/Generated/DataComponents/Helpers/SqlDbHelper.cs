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
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Microdata.DataComponents.Helpers
{

	/// <summary>
	/// Sql data base helper class that uses the SqlClient for optimised Sql Server data access.
	/// </summary>
    sealed class SqlDbHelper : IDbHelper
    {
		
		#region Members and constants

		private int? _commandTimeout;
		private const int COMMAND_TIMEOUT = 30;
        private const IsolationLevel DEFAULT_ISOLATION_LEVEL = IsolationLevel.ReadCommitted;

        #endregion Members and constants
        
		#region Public methods
		
		/// <summary>
		/// Creates a new connection.
		/// </summary>
		/// <param name="connectionString">Connection string.</param>
		/// <returns>DbConnection.</returns>
		/// <exception cref="DbHelperException">DbHelperException.</exception>
        public DbConnection CreateConnection(string connectionString)
        {
			DbConnection connection;
			
            try
            {
				connection = new SqlConnection(connectionString);
			}
			catch (Exception ex)
			{
                throw new DbHelperException(ex.Message + " An error occured while creating a new SQL connection.", ex);
			}
			
            return connection;
        }

		/// <summary>
		/// Creates a new Data Adapter.
		/// </summary>
		/// <returns>DbDataAdapter.</returns>
        public DbDataAdapter CreateDataAdapter()
        {
            return new SqlDataAdapter();
        }
        
        /// <summary>
		/// Creates a new command.
		/// </summary>
		/// <param name="commandText">Command text.</param>
		/// <param name="connection">DbConnection.</param>
		/// <param name="transaction">DbTransaction.</param>
		/// <returns>DbCommand.</returns>
		/// <exception cref="DbHelperException">DbHelperException.</exception>
        public DbCommand CreateCommand(string commandText, DbConnection connection, DbTransaction transaction)
        {
			DbCommand command;
			
			try
			{
                command = connection.CreateCommand();
                command.CommandText = commandText;
				command.CommandType = CommandType.Text;
				command.CommandTimeout = CommandTimeout;
				
				if (transaction != null)
				{
					command.Transaction = transaction;
					command.Connection = transaction.Connection;
				}
			}
            catch (Exception ex)
            {
                throw new DbHelperException(ex.Message + " An error occured while creating a new command.", ex);
            }
            
            return command; 
        }

		/// <summary>
		/// Creates a new stored procedure command.
		/// </summary>
		/// <param name="procedureName">Procedure name.</param>
		/// <param name="connection">DbConnection.</param>
		/// <param name="transaction">DbTransaction.</param>
		/// <returns>DbCommand.</returns>
		/// <exception cref="DbHelperException">DbHelperException.</exception>
        public DbCommand CreateStoredProcedureCommand(string procedureName, DbConnection connection, DbTransaction transaction)
        {
			DbCommand command;
			
			try
			{
				if (!procedureName.StartsWith("["))
					procedureName = "[" + procedureName;
					
				if (!procedureName.EndsWith("["))
					procedureName += "]";
					
                command = connection.CreateCommand();
                command.CommandText = procedureName;
				command.CommandType = CommandType.StoredProcedure;
				command.CommandTimeout = CommandTimeout;
				
				if (transaction != null)
				{
					command.Transaction = transaction;
					command.Connection = transaction.Connection;
				}
			}
            catch (Exception ex)
            {
                throw new DbHelperException(ex.Message + " An error occured while creating a new command.", ex);
            }
            
            return command; 
        }
        
        /// <summary>
        /// Adds a return value parameter to the command object.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="dbType">DbType.</param>
        public void AddReturnValueParameter(DbCommand command, string parameterName, DbType dbType)
        {
            AddReturnValueParameter(command, parameterName, dbType, null, null, null);
        }
        
        /// <summary>
        /// Adds a return value parameter to the command object.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        public void AddReturnValueParameter(DbCommand command, string parameterName, DbType dbType, int size)
        {
            AddReturnValueParameter(command, parameterName, dbType, size, null, null);
        }

        /// <summary>
        /// Adds a return value parameter to the command object.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        public void AddReturnValueParameter(DbCommand command, string parameterName, DbType dbType, byte precision, byte scale)
        {
            AddReturnValueParameter(command, parameterName, dbType, null, precision, scale);
        }

        /// <summary>
        /// Adds a return value parameter to the command object.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        private void AddReturnValueParameter(DbCommand command, string parameterName, DbType dbType, int? size, byte? precision, byte? scale)
        {
            parameterName = GetParameterName(parameterName);
            SqlCommand cmd = (SqlCommand)command;
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = parameterName;
            parameter.Direction = ParameterDirection.ReturnValue;
            parameter.DbType = dbType;

            if (size.HasValue)
                parameter.Size = size.Value;
 
            if (precision.HasValue)
                parameter.Precision = precision.Value;

            if (scale.HasValue)
                parameter.Scale = scale.Value;

            cmd.Parameters.Add(parameter);
        }

		/// <summary>
		/// Adds an input parameter.
		/// </summary>
		/// <param name="command">DbCommand.</param>
		/// <param name="parameterName">Parameter name.</param>
		/// <param name="parameterValue">Parameter value.</param>
        public void AddInParameter(DbCommand command, string parameterName, object parameterValue)
        {
            AddInParameter(command, parameterName, parameterValue, null, null, null, null, null);
        }

		/// <summary>
		/// Adds an input parameter.
		/// </summary>
		/// <param name="command">DbCommand.</param>
		/// <param name="parameterName">Parameter name.</param>
		/// <param name="parameterValue">Parameter value.</param>
		/// <param name="dbType">DbType.</param>
        public void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType)
        {
            AddInParameter(command, parameterName, parameterValue, dbType, null, null, null, null);
        }

        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="sourceColumn">Source column.</param>
        public void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, string sourceColumn)
        {
            AddInParameter(command, parameterName, parameterValue, dbType, sourceColumn, null, null, null);
        }

        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        public void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, int size)
        {
            AddInParameter(command, parameterName, parameterValue, dbType, null, size, null, null);
        }

        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        /// <param name="sourceColumn">Source column.</param>
        public void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, int size, string sourceColumn)
        {
            AddInParameter(command, parameterName, parameterValue, dbType, sourceColumn, size, null, null);
        }

        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        public void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, byte precision, byte scale)
        {
            AddInParameter(command, parameterName, parameterValue, dbType, null, null, precision, scale);
        }

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
        public void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, string sourceColumn, byte precision, byte scale)
        {
            AddInParameter(command, parameterName, parameterValue, dbType, sourceColumn, null, precision, scale);
        }

        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="sourceColumn">Source column.</param>
        /// <param name="size">Size.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        private void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType? dbType, string sourceColumn, int? size, byte? precision, byte? scale)
        {
            parameterName = GetParameterName(parameterName);
            SqlCommand cmd = (SqlCommand)command;
            SqlParameter parameter = new SqlParameter();
            parameter.Direction = ParameterDirection.Input;
            parameter.ParameterName = parameterName;
            SetParameterValue(parameter, parameterValue);

            if (dbType.HasValue)
                parameter.DbType = dbType.Value;
            
            if (!string.IsNullOrEmpty(sourceColumn))
                parameter.SourceColumn = sourceColumn;

            if (size.HasValue)
                parameter.Size = size.Value;

            if (precision.HasValue)
                parameter.Precision = precision.Value;

            if (scale.HasValue)
                parameter.Scale = scale.Value;

            cmd.Parameters.Add(parameter);
        }

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        public void AddOutParameter(DbCommand command, string parameterName, object parameterValue)
        {
            AddOutParameter(command, parameterName, parameterValue, null, null, null, null, null);
        }

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        public void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType)
        {
            AddOutParameter(command, parameterName, parameterValue, dbType, null, null, null, null);
        }

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="sourceColumn">Source column.</param>
        public void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, string sourceColumn)
        {
            AddOutParameter(command, parameterName, parameterValue, dbType, sourceColumn, null, null, null);
        }

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        public void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, int size)
        {
            AddOutParameter(command, parameterName, parameterValue, dbType, null, size, null, null);
        }

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        /// <param name="sourceColumn">Source column.</param>
        public void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, int size, string sourceColumn)
        {
            AddOutParameter(command, parameterName, parameterValue, dbType, sourceColumn, size, null, null);
        }

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        public void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, byte precision, byte scale)
        {
            AddOutParameter(command, parameterName, parameterValue, dbType, null, null, precision, scale);
        }

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
        public void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, string sourceColumn, byte precision, byte scale)
        {
            AddOutParameter(command, parameterName, parameterValue, dbType, sourceColumn, null, precision, scale);
        }

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        /// <param name="sourceColumn">Source column.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        private void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType? dbType, string sourceColumn, int? size, byte? precision, byte? scale)
        {
            parameterName = GetParameterName(parameterName);
            SqlCommand cmd = (SqlCommand)command;
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = parameterName;
            SetParameterValue(parameter, parameterValue);
            parameter.Direction = ParameterDirection.InputOutput;

            if (dbType.HasValue)
                parameter.DbType = dbType.Value;
            
            if (!string.IsNullOrEmpty(sourceColumn))
                parameter.SourceColumn = sourceColumn;

            if (size.HasValue)
                parameter.Size = size.Value;

            if (precision.HasValue)
                parameter.Precision = precision.Value;

            if (scale.HasValue)
                parameter.Scale = scale.Value;

            cmd.Parameters.Add(parameter);
        }

        /// <summary>
        /// Sets a parameters value.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        public void SetParameterValue(DbCommand command, string parameterName, object parameterValue)
        {
            try
            {
                parameterName = GetParameterName(parameterName);
                SqlCommand cmd = (SqlCommand)command;
                SqlParameter parameter = cmd.Parameters[parameterName];
                SetParameterValue(parameter, parameterValue);
            }
            catch (Exception ex)
            {
                throw new DbHelperException("Could not set the value of parameter '" + parameterName + "'. " + ex.Message );
            }
        }

        /// <summary>
        /// Gets a parameter value.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <returns>Parameter value as an object.</returns>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        public object GetParameterValue(DbCommand command, string parameterName)
        {
            object paramterValue;

            try
            {
                parameterName = GetParameterName(parameterName);
                SqlCommand cmd = (SqlCommand)command;
                SqlParameter parameter = cmd.Parameters[parameterName];
                paramterValue = parameter.Value;
            }
            catch (Exception ex)
            {
                throw new DbHelperException("Could not get the value of parameter '" + parameterName + "'. " + ex.Message);
            }

            return paramterValue;
        }
        
        /// <summary>
        /// Checks whether a parameter exists.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <returns>True if found, otherwise false.</returns>
        public bool CheckParameterExists(DbCommand command, string parameterName)
        {
            parameterName = GetParameterName(parameterName);

            foreach (SqlParameter parameter in command.Parameters)
            {
                if (parameter.ParameterName == parameterName)
                    return true;
            }

            return false;
        }
		
		/// <summary>
        /// Creates a new transaction.
        /// </summary>
        /// <param name="connection">DbConnection.</param>
        /// <returns>DbTransaction.</returns>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        public DbTransaction CreateTransaction(DbConnection connection)
        {
            return CreateTransaction(connection, null, string.Empty);
        }

        /// <summary>
        /// Creates a new transaction.
        /// </summary>
        /// <param name="connection">DbConnection.</param>
        /// <param name="transactionName">The name of the transaction.</param>
        /// <returns>DbTransaction.</returns>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        public DbTransaction CreateTransaction(DbConnection connection, string transactionName)
        {
            return CreateTransaction(connection, null, transactionName);
        }

        /// <summary>
        /// Creates a new transaction.
        /// </summary>
        /// <param name="connection">DbConnection.</param>
        /// <param name="isolationLevel">The isolation level to use.</param>
        /// <returns>DbTransaction.</returns>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        public DbTransaction CreateTransaction(DbConnection connection, IsolationLevel isolationLevel)
        {
            return CreateTransaction(connection, isolationLevel, string.Empty);
        }

		/// <summary>
		/// Creates a new transaction.
		/// </summary>
		/// <param name="connection">DbConnection.</param>
        /// <param name="isolationLevel">The isolation level to use.</param>
        /// <param name="transactionName">The name of the transaction.</param>
		/// <returns>DbTransaction.</returns>
		/// <exception cref="DbHelperException">DbHelperException.</exception>
        public DbTransaction CreateTransaction(DbConnection connection, IsolationLevel? isolationLevel, string transactionName)
        {
            DbTransaction transaction;
            transactionName = transactionName.Trim();

            try
            {
				// open connection and begin transaction
                SqlConnection sqlConnection = (SqlConnection)connection;
                sqlConnection.Open();

                if (isolationLevel.HasValue)
                    transaction = sqlConnection.BeginTransaction((IsolationLevel)isolationLevel, transactionName);
                else
                    transaction = sqlConnection.BeginTransaction(DEFAULT_ISOLATION_LEVEL, transactionName);
            }
            catch (Exception ex)
            {
                throw new DbHelperException(ex.Message + " An error occured while trying to create a new transaction.", ex);
            }

            return transaction;
        }
        
        #endregion Public methods
        
        #region Private methods

        /// <summary>
        /// Returns the SQL parameter name for the given parameter name, prefixes it with '@'.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <returns>string.</returns>
        private string GetParameterName(string parameterName)
        {
            if (!parameterName.StartsWith("@"))
                parameterName = "@" + parameterName;
            return parameterName;
        }
        
        /// <summary>
        /// Sets the value of a parameter.
        /// </summary>
        /// <param name="parameter">SqlParameter.</param>
        /// <param name="parameterValue">Parameter value.</param>
        private void SetParameterValue(SqlParameter parameter, object parameterValue)
        {
            if (parameterValue == null)
            {
                parameter.IsNullable = true;
                parameterValue = DBNull.Value;
            }
            else if (parameterValue is DateTime && ((DateTime)parameterValue) == DateTime.MinValue)
                parameterValue = System.Data.SqlTypes.SqlDateTime.MinValue;
                
            parameter.Value = parameterValue;
        }

        #endregion Private methods
        
        #region Properties
        
        /// <summary>
        /// Gets or sets the command timout period.
        /// </summary>
        /// <returns>Command timeout period.</returns>
        public int CommandTimeout
        {
			get
			{
				return (_commandTimeout.HasValue ? _commandTimeout.Value : COMMAND_TIMEOUT);
			}
			set
			{
				_commandTimeout = value;
			}
        }
        
        #endregion Properties

    }
}
