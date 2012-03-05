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
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Microdata.DataComponents
{
	using BusinessComponents.Entities;
	using Helpers;
	
	/// <summary>
	/// Base class for all data access objects.
	/// </summary>
	public abstract partial class DataAccessBase : IDataAccessBase
	{
		
		#region Enums
		
		/// <summary>
		/// Enum for all available databases.
		/// </summary>
		protected enum Databases
        {
			/// <summary>
			/// Microdata Database
			/// </summary>
            Microdata
        }
		
		#endregion Enums

		#region Members and Constants

		private string _tableName = string.Empty;
		private IDbHelper _dbHelper;
		private DbDataAdapter _dataAdapter;
		private DbDataReader _dataReader;
		private DbConnection _connection;
		private DbCommand _insertCommand;
		private DbCommand _deleteCommand;
		private DbCommand _updateCommand;
		private DbCommand _command;
		private Databases _database = Databases.Microdata;
		private bool _initialising;
		private string _appSettingsKeyPrefix;
		
		private const Databases DEFAULT_DATABASE = Databases.Microdata;
        private const DbHelperType DEFAULT_DATABASE_HELPER_TYPE = DbHelperType.SqlServer;

		#endregion Members and Constants

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		/// <exception cref="DataLayerException">DataLayerException.</exception>
		protected DataAccessBase()
		{
            Initialise(DEFAULT_DATABASE);
		}

        /// <summary>
        /// Overriden constructor which accepts a database.
        /// </summary>
        /// <param name="database">Database to use.</param>
        protected DataAccessBase(Databases database)
        {
            Initialise(database);
        }

		#endregion Constructors
		
		#region Delegates

		/// <summary>
        /// Build entities delegate
        /// </summary>
        protected delegate IEntities BuildEntitiesDelegate();

        #endregion Delegates

		#region Methods

        #region Create command methods

        /// <summary>
        /// Creates a stored procedure command
        /// </summary>
        /// <param name="procedureName">Procedure name</param>
        protected void PrepareStoredProcedureCommand(string procedureName)
        {
            Command = DBHelper.CreateStoredProcedureCommand(procedureName, Connection, null);
        }

        /// <summary>
        /// Creates a stored procedure command
        /// </summary>
        /// <param name="procedureName">Procedure name</param>
        /// <param name="transaction">DbTransaction</param>
        protected void PrepareStoredProcedureCommand(string procedureName, DbTransaction transaction)
        {
            Command = DBHelper.CreateStoredProcedureCommand(procedureName, Connection, transaction);
        }
        
        /// <summary>
        /// Creates a stored procedure command
        /// </summary>
        /// <param name="procedureName">Procedure name</param>
        /// <returns>DbCommand</returns>
        protected DbCommand CreateStoredProcedureCommand(string procedureName)
        {
            return DBHelper.CreateStoredProcedureCommand(procedureName, Connection, null);
        }

        /// <summary>
        /// Creates a stored procedure command
        /// </summary>
        /// <param name="procedureName">Procedure name</param>
        /// <param name="transaction">DbTransaction</param>
        /// <returns>DbCommand</returns>
        protected DbCommand CreateStoredProcedureCommand(string procedureName, DbTransaction transaction)
        {
            return DBHelper.CreateStoredProcedureCommand(procedureName, Connection, transaction);
        }

        /// <summary>
        /// Creates a new command
        /// </summary>
        /// <param name="commandText"></param>
        protected void PrepareCommand(string commandText)
        {
            Command = DBHelper.CreateCommand(commandText, Connection, null);
        }

        /// <summary>
        /// Creates a new command
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="transaction">DbTransaction</param>
        protected void PrepareCommand(string commandText, DbTransaction transaction)
        {
            Command = DBHelper.CreateCommand(commandText, Connection, transaction);
        }
        
        /// <summary>
        /// Creates a new command
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns>DbCommand</returns>
        protected DbCommand CreateCommand(string commandText)
        {
            return DBHelper.CreateCommand(commandText, Connection, null);
        }

        /// <summary>
        /// Creates a new command
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="transaction">DbTransaction</param>
        /// <returns>DbCommand</returns>
        protected DbCommand CreateCommand(string commandText, DbTransaction transaction)
        {
            return DBHelper.CreateCommand(commandText, Connection, transaction);
        }
        
        /// <summary>
        /// Creates the insert command and should be overriden.
        /// </summary>
        /// <param name="entity">Entity object</param>
        protected void CreateInsertCommand(IEntity entity)
        {
            CreateInsertCommand(entity, null);
        }

        /// <summary>
        /// Creates the insert command and should be overriden.
        /// </summary>
        /// <param name="entity">Entity object</param>
        /// <param name="transaction">DbTransaction.</param>
        protected virtual void CreateInsertCommand(IEntity entity, DbTransaction transaction)
        {
            InsertCommand = null;
            if (entity != null)
				throw new Exception("The CreateInsertCommand method has not been overriden.");
        }

        /// <summary>
        /// Creates the delete command.
        /// </summary>
        /// <param name="entity">Entity object</param>
        protected void CreateDeleteCommand(IEntity entity)
        {
            CreateDeleteCommand(entity, null);
        }

        /// <summary>
        /// Creates the delete command.
        /// </summary>
        /// <param name="entity">Entity object</param>
        /// <param name="transaction">DbTransaction.</param>
        protected virtual void CreateDeleteCommand(IEntity entity, DbTransaction transaction)
        {
            DeleteCommand = null;
            if (entity != null)
				throw new Exception("The CreateDeleteCommand method has not been overriden.");
        }

        /// <summary>
        /// Creates the update command.
        /// </summary>
        /// <param name="entity">Entity object</param>
        protected void CreateUpdateCommand(IEntity entity)
        {
            CreateUpdateCommand(entity, null);
        }

        /// <summary>
        /// Creates the update command.
        /// </summary>
        /// <param name="entity">Entity object</param>
        /// <param name="transaction">DbTransaction.</param>
        protected virtual void CreateUpdateCommand(IEntity entity, DbTransaction transaction)
        {
            UpdateCommand = null;
            if (entity != null)
				throw new Exception("The CreateUpdateCommand method has not been overriden.");
        }
        
        /// <summary>
        /// Creates all updating commands (Insert, Update and Delete).
        /// </summary>
        /// <param name="transaction">DbTransaction.</param>
        private void CreateUpdateCommands(DbTransaction transaction)
        {
            if (InsertCommand == null)
                CreateInsertCommand(null, transaction);
                
            if (DeleteCommand == null)
                CreateDeleteCommand(null, transaction);
                
            if (UpdateCommand == null)
                CreateUpdateCommand(null, transaction);

            if (InsertCommand != null)
                DataAdapter.InsertCommand = InsertCommand;

            if (UpdateCommand != null)
			    DataAdapter.UpdateCommand = UpdateCommand;

            if (DeleteCommand != null)
			    DataAdapter.DeleteCommand = DeleteCommand;
        }

        #endregion Create command methods

        #region Query methods

        /// <summary>
        /// Fills a data table
        /// </summary>
        /// <param name="table"></param>
        protected void ExecuteDataTable(DataTable table)
        {
            ExecuteDataTable(Command, table);
        }

        /// <summary>
        /// Fills a data table
        /// </summary>
        /// <param name="command">DbCommand</param>
        /// <param name="table">table to fill</param>
        protected void ExecuteDataTable(DbCommand command, DataTable table)
        {
            if (command == null)
                throw new Exception("The command object has not been initialised.");

            bool connectionOpen = (Command.Connection.State == ConnectionState.Open);

            try
            {
                DataAdapter.SelectCommand = command;
                DataAdapter.Fill(table);
                if (!connectionOpen)
                    CloseConnection();
            }
            finally
            {
                if (!connectionOpen)
                    CloseConnection();
            }
        }
        
        /// <summary>
        /// Fills a data set
        /// </summary>
        /// <param name="dataSet">DataSet to fill</param>
        protected void ExecuteDataSet(DataSet dataSet)
        {
            ExecuteDataSet(Command, dataSet);
        }

        /// <summary>
        /// Fills a data set
        /// </summary>
        /// <param name="command">DbCommand</param>
        /// <param name="dataSet">DataSet to fill</param>
        protected void ExecuteDataSet(DbCommand command, DataSet dataSet)
        {
            if (command == null)
                throw new Exception("The command object has not been initialised.");

            bool connectionOpen = (command.Connection.State == ConnectionState.Open);

            try
            {
                DataAdapter.SelectCommand = command;
                DataAdapter.Fill(dataSet);
                if (!connectionOpen)
                    CloseConnection();
            }
            finally
            {
                if (!connectionOpen)
                    CloseConnection();
            }
        }
        
        /// <summary>
        /// Executes a non query
        /// </summary>
        /// <param name="command">DbCommand</param>
        /// <param name="transaction">DbTransaction</param>
        /// <returns>Number of rows affected.</returns>
        protected int ExecuteNonQuery(DbCommand command, DbTransaction transaction)
        {
            if (command == null)
                throw new Exception("The command object has not been initialised.");

            int rowsAffected = 0;
            bool connectionOpen = (command.Connection.State == ConnectionState.Open);

            try
            {
                if (transaction == null)
					OpenConnection();
                rowsAffected = command.ExecuteNonQuery();
                if (!connectionOpen && transaction == null)
                    CloseConnection();
            }
            finally
            {
                if (!connectionOpen && transaction == null)
                    CloseConnection();
            }

            return rowsAffected;
        }

        /// <summary>
        /// Executes a non query
        /// </summary>
        /// <returns>Number of rows affected.</returns>
        protected int ExecuteNonQuery()
        {
			return ExecuteNonQuery(Command, null);
        }
        
        /// <summary>
        /// Executes a non query
        /// </summary>
        /// <param name="command">DbCommand</param>
        /// <returns>Number of rows affected.</returns>
        protected int ExecuteNonQuery(DbCommand command)
        {
			return ExecuteNonQuery(command, null);
        }
        
        /// <summary>
        /// Executes a non query
        /// </summary>
        /// <param name="transaction">DbTransaction</param>
        /// <returns>Number of rows affected.</returns>
        protected int ExecuteNonQuery(DbTransaction transaction)
        {
			return ExecuteNonQuery(Command, transaction);
        }
        
        /// <summary>
        /// Executes a non query.
        /// </summary>
        /// <param name="commandType">Command type.</param>
        /// <param name="commandText">Command text.</param>
        /// <returns>Number of rows affected.</returns>
        /// <exception cref="DataLayerException">DataLayerException</exception>
        protected int ExecuteNonQuery(CommandType commandType, string commandText)
        {
            return ExecuteNonQuery(commandType, commandText, null);
        }

        /// <summary>
        /// Executes a non query.
        /// </summary>
        /// <param name="commandText">Command text.</param>
        /// <returns>Number of rows affected.</returns>
        /// <exception cref="DataLayerException">DataLayerException</exception>
        protected int ExecuteNonQuery(string commandText)
        {
            return ExecuteNonQuery(CommandType.StoredProcedure, commandText, null);
        }

        /// <summary>
        /// Executes a non query.
        /// </summary>
        /// <param name="commandText">Command text.</param>
        /// <param name="parameters">Parameters.</param>
        /// <returns>Number of rows affected.</returns>
        /// <exception cref="DataLayerException">DataLayerException</exception>
        protected int ExecuteNonQuery(string commandText, DataParameters parameters)
        {
            return ExecuteNonQuery(CommandType.StoredProcedure, commandText, parameters);
        }

        /// <summary>
        /// Executes a non query.
        /// </summary>
        /// <param name="commandType">Command type.</param>
        /// <param name="commandText">Command text.</param>
        /// <param name="parameters">Parameters.</param>
        /// <returns>Number of rows affected.</returns>
        /// <exception cref="DataLayerException">DataLayerException</exception>
        protected int ExecuteNonQuery(CommandType commandType, string commandText, DataParameters parameters)
        {
            int rowsAffected = 0;

            try
            {
                if (commandType == CommandType.StoredProcedure)
                {
                    if (string.IsNullOrEmpty(commandText))
                        throw new DataLayerException("The stored procedure name is empty.");

                    PrepareStoredProcedureCommand(commandText);
                }
                else
                    PrepareCommand(commandText);

                AddParameters(Command, parameters);
                rowsAffected = ExecuteNonQuery();
                GetOutputParameterValues(Command, parameters);
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(ex.Message);
                
                if (commandType == CommandType.StoredProcedure && !string.IsNullOrEmpty(commandText))
                    sb.Append(" An error occurred during the execution of stored procedure '" + commandText + "'.");
                    
                sb.Append(" An unexpected error occurred.");
                HandleException(ex, sb.ToString());
            }
            finally
            {
                ReleaseCommand();
            }

            return rowsAffected;
        }
        
        /// <summary>
        /// Executes a scalar query
        /// </summary>
        protected object ExecuteScalar()
        {
            return ExecuteScalar(Command);
        }

        /// <summary>
        /// Executes a scalar query
        /// </summary>
        /// <param name="command">DbCommand</param>
        protected object ExecuteScalar(DbCommand command)
        {
            if (command == null)
                throw new Exception("The command object has not been initialised.");

            object value;
            bool connectionOpen = (command.Connection.State == ConnectionState.Open);

            try
            {
                OpenConnection();
                value = command.ExecuteScalar();
                if (!connectionOpen)
                    CloseConnection();
            }
            finally
            {
                if (!connectionOpen)
                    CloseConnection();
            }

            return value;
        }
        
        /// <summary>
        /// Executes a scalar query
        /// </summary>
        /// <typeparam name="T">Type of object to be returned</typeparam>
        protected T ExecuteScalar<T>()
        {
            return ExecuteScalar<T>(Command);
        }

        /// <summary>
        /// Executes a scalar query
        /// </summary>
        /// <param name="command">DbCommand</param>
        /// <typeparam name="T">Type of object to be returned</typeparam>
        protected T ExecuteScalar<T>(DbCommand command)
        {
            return (T)ExecuteScalar(command);
        }
        
        /// <summary>
        /// Executes a scalar query.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="commandType">Command type.</param>
        /// <param name="commandText">Command text.</param>
        /// <returns>Scalar value.</returns>
        protected T ExecuteScalar<T>(CommandType commandType, string commandText)
        {
            return ExecuteScalar<T>(commandType, commandText, null);
        }

        /// <summary>
        /// Executes a scalar query.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="commandText">Command text.</param>
        /// <returns>Scalar value.</returns>
        protected T ExecuteScalar<T>(string commandText)
        {
            return ExecuteScalar<T>(CommandType.StoredProcedure, commandText, null);
        }

        /// <summary>
        /// Executes a scalar query.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="commandText">Command text.</param>
        /// <param name="parameters">Parameters.</param>
        /// <returns>Scalar value.</returns>
        protected T ExecuteScalar<T>(string commandText, DataParameters parameters)
        {
            return ExecuteScalar<T>(CommandType.StoredProcedure, commandText, parameters);
        }

        /// <summary>
        /// Executes a scalar query.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="commandType">Command type.</param>
        /// <param name="commandText">Command text.</param>
        /// <param name="parameters">Parameters.</param>
        /// <returns>Scalar value.</returns>
        protected T ExecuteScalar<T>(CommandType commandType, string commandText, DataParameters parameters)
        {
            T value = default(T);

            try
            {
                if (commandType == CommandType.StoredProcedure)
                {
                    if (string.IsNullOrEmpty(commandText))
                        throw new DataLayerException("The stored procedure name is empty.");

                    PrepareStoredProcedureCommand(commandText);
                }
                else
                    PrepareCommand(commandText);

                AddParameters(Command, parameters);
                value = ExecuteScalar<T>();
                GetOutputParameterValues(Command, parameters);
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(ex.Message);
                
                if (commandType == CommandType.StoredProcedure && !string.IsNullOrEmpty(commandText))
                    sb.Append(" An error occurred during the execution of stored procedure '" + commandText + "'.");
                    
                sb.Append(" An unexpected error occurred.");
                HandleException(ex, sb.ToString());
            }
            finally
            {
                ReleaseCommand();
            }

            return value;
        }
        
        /// <summary>
        /// Creates a new data reader
        /// </summary>
        protected void ExecuteReader()
        {
            ExecuteReader(Command);
        }

        /// <summary>
        /// Creates a new data reader
        /// </summary>
        /// <param name="command">DbCommand</param>
        protected void ExecuteReader(DbCommand command)
        {
			DataReader = null;
			
            if (command == null)
                throw new Exception("The command object has not been initialised.");

            OpenConnection();
            DataReader = command.ExecuteReader();
        }

        #endregion Query methods

        #region Parameter related methods

        /// <summary>
        /// Adds a return value parameter to the command object.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="dbType">DbType.</param>
        protected void AddReturnValueParameter(string parameterName, DbType dbType)
        {
            DBHelper.AddReturnValueParameter(Command, parameterName, dbType);
        }
        
        /// <summary>
        /// Adds a return value parameter to the command object.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="dbType">DbType.</param>
        protected void AddReturnValueParameter(DbCommand command, string parameterName, DbType dbType)
        {
            DBHelper.AddReturnValueParameter(command, parameterName, dbType);
        }

        /// <summary>
        /// Adds a return value parameter to the command object.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        protected void AddReturnValueParameter(string parameterName, DbType dbType, int size)
        {
            DBHelper.AddReturnValueParameter(Command, parameterName, dbType, size);
        }
        
        /// <summary>
        /// Adds a return value parameter to the command object.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        protected void AddReturnValueParameter(DbCommand command, string parameterName, DbType dbType, int size)
        {
            DBHelper.AddReturnValueParameter(command, parameterName, dbType, size);
        }

        /// <summary>
        /// Adds a return value parameter to the command object.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        protected void AddReturnValueParameter(string parameterName, DbType dbType, byte precision, byte scale)
        {
            DBHelper.AddReturnValueParameter(Command, parameterName, dbType, precision, scale);
        }
        
        /// <summary>
        /// Adds a return value parameter to the command object.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        protected void AddReturnValueParameter(DbCommand command, string parameterName, DbType dbType, byte precision, byte scale)
        {
            DBHelper.AddReturnValueParameter(command, parameterName, dbType, precision, scale);
        }

        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        protected void AddInParameter(string parameterName, object parameterValue)
        {
            DBHelper.AddInParameter(Command, parameterName, parameterValue);
        }
        
        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        protected void AddInParameter(DbCommand command, string parameterName, object parameterValue)
        {
            DBHelper.AddInParameter(command, parameterName, parameterValue);
        }

        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        protected void AddInParameter(string parameterName, object parameterValue, DbType dbType)
        {
            DBHelper.AddInParameter(Command, parameterName, parameterValue, dbType);
        }
        
        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        protected void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType)
        {
            DBHelper.AddInParameter(command, parameterName, parameterValue, dbType);
        }

        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="sourceColumn">Source column.</param>
        protected void AddInParameter(string parameterName, object parameterValue, DbType dbType, string sourceColumn)
        {
            DBHelper.AddInParameter(Command, parameterName, parameterValue, dbType, sourceColumn);
        }
        
        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="sourceColumn">Source column.</param>
        protected void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, string sourceColumn)
        {
            DBHelper.AddInParameter(command, parameterName, parameterValue, dbType, sourceColumn);
        }

        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        protected void AddInParameter(string parameterName, object parameterValue, DbType dbType, int size)
        {
            DBHelper.AddInParameter(Command, parameterName, parameterValue, dbType, size);
        }
        
        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        protected void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, int size)
        {
            DBHelper.AddInParameter(command, parameterName, parameterValue, dbType, size);
        }

        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        /// <param name="sourceColumn">Source column.</param>
        protected void AddInParameter(string parameterName, object parameterValue, DbType dbType, int size, string sourceColumn)
        {
            DBHelper.AddInParameter(Command, parameterName, parameterValue, dbType, size, sourceColumn);
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
        protected void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, int size, string sourceColumn)
        {
            DBHelper.AddInParameter(command, parameterName, parameterValue, dbType, size, sourceColumn);
        }

        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        protected void AddInParameter(string parameterName, object parameterValue, DbType dbType, byte precision, byte scale)
        {
            DBHelper.AddInParameter(Command, parameterName, parameterValue, dbType, precision, scale);
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
        protected void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, byte precision, byte scale)
        {
            DBHelper.AddInParameter(command, parameterName, parameterValue, dbType, precision, scale);
        }

        /// <summary>
        /// Adds an input parameter.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="sourceColumn">Source column.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        protected void AddInParameter(string parameterName, object parameterValue, DbType dbType, string sourceColumn, byte precision, byte scale)
        {
            DBHelper.AddInParameter(Command, parameterName, parameterValue, dbType, sourceColumn, precision, scale);
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
        protected void AddInParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, string sourceColumn, byte precision, byte scale)
        {
            DBHelper.AddInParameter(command, parameterName, parameterValue, dbType, sourceColumn, precision, scale);
        }

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        protected void AddOutParameter(string parameterName, object parameterValue)
        {
            DBHelper.AddOutParameter(Command, parameterName, parameterValue);
        }
        
        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        protected void AddOutParameter(DbCommand command, string parameterName, object parameterValue)
        {
            DBHelper.AddOutParameter(command, parameterName, parameterValue);
        }

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        protected void AddOutParameter(string parameterName, object parameterValue, DbType dbType)
        {
            DBHelper.AddOutParameter(Command, parameterName, parameterValue, dbType);
        }
        
        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        protected void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType)
        {
            DBHelper.AddOutParameter(command, parameterName, parameterValue, dbType);
        }

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="sourceColumn">Source column.</param>
        protected void AddOutParameter(string parameterName, object parameterValue, DbType dbType, string sourceColumn)
        {
            DBHelper.AddOutParameter(Command, parameterName, parameterValue, dbType, sourceColumn);
        }
        
        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="sourceColumn">Source column.</param>
        protected void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, string sourceColumn)
        {
            DBHelper.AddOutParameter(command, parameterName, parameterValue, dbType, sourceColumn);
        }

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        protected void AddOutParameter(string parameterName, object parameterValue, DbType dbType, int size)
        {
            DBHelper.AddOutParameter(Command, parameterName, parameterValue, dbType, size);
        }
        
        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        protected void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, int size)
        {
            DBHelper.AddOutParameter(command, parameterName, parameterValue, dbType, size);
        }

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        /// <param name="sourceColumn">Source column.</param>
        protected void AddOutParameter(string parameterName, object parameterValue, DbType dbType, int size, string sourceColumn)
        {
            DBHelper.AddOutParameter(Command, parameterName, parameterValue, dbType, size, sourceColumn);
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
        protected void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, int size, string sourceColumn)
        {
            DBHelper.AddOutParameter(command, parameterName, parameterValue, dbType, size, sourceColumn);
        }

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        protected void AddOutParameter(string parameterName, object parameterValue, DbType dbType, byte precision, byte scale)
        {
            DBHelper.AddOutParameter(Command, parameterName, parameterValue, dbType, precision, scale);
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
        protected void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, byte precision, byte scale)
        {
            DBHelper.AddOutParameter(command, parameterName, parameterValue, dbType, precision, scale);
        }

        /// <summary>
        /// Adds an output parameter.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="sourceColumn">Source column.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        protected void AddOutParameter(string parameterName, object parameterValue, DbType dbType, string sourceColumn, byte precision, byte scale)
        {
            DBHelper.AddOutParameter(Command, parameterName, parameterValue, dbType, sourceColumn, precision, scale);
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
        protected void AddOutParameter(DbCommand command, string parameterName, object parameterValue, DbType dbType, string sourceColumn, byte precision, byte scale)
        {
            DBHelper.AddOutParameter(command, parameterName, parameterValue, dbType, sourceColumn, precision, scale);
        }

        /// <summary>
        /// Sets a parameters value.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        protected void SetParameterValue(string parameterName, object parameterValue)
        {
            DBHelper.SetParameterValue(Command, parameterName, parameterValue);
        }
        
        /// <summary>
        /// Sets a parameters value.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <param name="parameterValue">Parameter value.</param>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        protected void SetParameterValue(DbCommand command, string parameterName, object parameterValue)
        {
            DBHelper.SetParameterValue(command, parameterName, parameterValue);
        }

        /// <summary>
        /// Gets a parameter value.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <returns>Parameter value as an object.</returns>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        protected object GetParameterValue(string parameterName)
        {
            return DBHelper.GetParameterValue(Command, parameterName);
        }

		/// <summary>
        /// Gets a parameter value.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <returns>Parameter value as an object.</returns>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        protected object GetParameterValue(DbCommand command, string parameterName)
        {
            return DBHelper.GetParameterValue(command, parameterName);
        }
        
        /// <summary>
        /// Gets a parameter value.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <returns>Parameter value as an object.</returns>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        protected T GetParameterValue<T>(string parameterName)
        {
            return (T)DBHelper.GetParameterValue(Command, parameterName);
        }

        /// <summary>
        /// Gets a parameter value.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <returns>Parameter value as an object.</returns>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        protected T GetParameterValue<T>(DbCommand command, string parameterName)
        {
            return (T)DBHelper.GetParameterValue(command, parameterName);
        }
        
        /// <summary>
        /// Checks whether a parameter exists.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <returns>True if found, otherwise false.</returns>
        protected bool CheckParameterExists(string parameterName)
        {
            return DBHelper.CheckParameterExists(Command, parameterName);
        }

        /// <summary>
        /// Checks whether a parameter exists.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameterName">Parameter name.</param>
        /// <returns>True if found, otherwise false.</returns>
        protected bool CheckParameterExists(DbCommand command, string parameterName)
        {
            return DBHelper.CheckParameterExists(command, parameterName);
        }
        
        /// <summary>
        /// Adds parameters to a command object
        /// </summary>
        /// <param name="command">DbCommand object</param>
        /// <param name="parameters">Parameters.</param>
        private void AddParameters(DbCommand command, DataParameters parameters)
        {
            if (parameters == null)
                return;

            foreach (DataParameter parameter in parameters)
            {
                if (parameter == null)
                    continue;

                if (string.IsNullOrEmpty(parameter.Name))
                    throw new Exception("A DataParameter name cannot be empty.");

                int type = -1;
                if (parameter.Direction == ParameterDirection.Input)
                    type = 0;
                else if (parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Output)
                    type = 1;
                else if (parameter.Direction == ParameterDirection.ReturnValue)
                    type = 2;

                switch (type)
                {
                    case 0:
                        if (parameter.DbType.HasValue && parameter.SourceColumn != null && parameter.Precision.HasValue && parameter.Scale.HasValue)
                            AddInParameter(command, parameter.Name, parameter.Value, parameter.DbType.Value, parameter.SourceColumn, parameter.Precision.Value, parameter.Scale.Value);
                        else if (parameter.DbType.HasValue && parameter.Precision.HasValue && parameter.Scale.HasValue)
                            AddInParameter(command, parameter.Name, parameter.Value, parameter.DbType.Value, parameter.Precision.Value, parameter.Scale.Value);
                        else if (parameter.DbType.HasValue && parameter.Size.HasValue)
                            AddInParameter(command, parameter.Name, parameter.Value, parameter.DbType.Value, parameter.Size.Value);
                        else if (parameter.DbType.HasValue && parameter.SourceColumn != null)
                            AddInParameter(command, parameter.Name, parameter.Value, parameter.DbType.Value, parameter.SourceColumn);
                        else if (parameter.DbType.HasValue)
                            AddInParameter(command, parameter.Name, parameter.Value, parameter.DbType.Value);
                        else
                            AddInParameter(command, parameter.Name, parameter.Value);
                        break;

                    case 1:
                        if (parameter.DbType.HasValue && parameter.SourceColumn != null && parameter.Precision.HasValue && parameter.Scale.HasValue)
                            AddOutParameter(command, parameter.Name, parameter.Value, parameter.DbType.Value, parameter.SourceColumn, parameter.Precision.Value, parameter.Scale.Value);
                        else if (parameter.DbType.HasValue && parameter.Precision.HasValue && parameter.Scale.HasValue)
                            AddOutParameter(command, parameter.Name, parameter.Value, parameter.DbType.Value, parameter.Precision.Value, parameter.Scale.Value);
                        else if (parameter.DbType.HasValue && parameter.Size.HasValue)
                            AddOutParameter(command, parameter.Name, parameter.Value, parameter.DbType.Value, parameter.Size.Value);
                        else if (parameter.DbType.HasValue && parameter.SourceColumn != null)
                            AddOutParameter(command, parameter.Name, parameter.Value, parameter.DbType.Value, parameter.SourceColumn);
                        else if (parameter.DbType.HasValue)
                            AddOutParameter(command, parameter.Name, parameter.Value, parameter.DbType.Value);
                        else
                            AddOutParameter(command, parameter.Name, parameter.Value);
                        break;
                    case 2:
                        if (parameter.DbType.HasValue && parameter.Precision.HasValue && parameter.Scale.HasValue)
                            AddReturnValueParameter(command, parameter.Name, parameter.DbType.Value, parameter.Precision.Value, parameter.Scale.Value);
                        else if (parameter.DbType.HasValue && parameter.Size.HasValue)
                            AddReturnValueParameter(command, parameter.Name, parameter.DbType.Value, parameter.Size.Value);
                        else if (parameter.DbType.HasValue)
                            AddReturnValueParameter(command, parameter.Name, parameter.DbType.Value);
                        break;
                }
            }
        }

        /// <summary>
        /// Gets all output parameter values.
        /// </summary>
        /// <param name="command">DbCommand.</param>
        /// <param name="parameters">Parameters.</param>
        private void GetOutputParameterValues(DbCommand command, DataParameters parameters)
        {
            if (parameters == null)
                return;

            foreach (DataParameter parameter in parameters)
            {
                if (parameter.Direction != ParameterDirection.InputOutput && parameter.Direction != ParameterDirection.Output &&
                    parameter.Direction != ParameterDirection.ReturnValue)
                    continue;

                parameter.Value = DBHelper.GetParameterValue(command, parameter.Name);
            }
        }

        #endregion Parameter related methods

        #region Disposal methods

        /// <summary>
        /// Releases a command object
        /// </summary>
        protected void ReleaseCommand()
        {
			ReleaseCommand(Command);
        }
        
        /// <summary>
        /// Releases a command object
        /// </summary>
        /// <param name="command">DbCommand</param>
        protected void ReleaseCommand(DbCommand command)
        {
            if (command != null)
                command.Dispose();
        }

        /// <summary>
        ///  Releases the reader object
        /// </summary>
        protected void ReleaseReader()
        {
            if (DataReader != null)
            {
                if (!DataReader.IsClosed)
                    DataReader.Close();
                DataReader.Dispose();
            }

            CloseConnection();
        }
        
        /// <summary>
        /// Releases the connection
        /// </summary>
        protected void ReleaseConnection()
        {
            if (Connection != null)
            {
                CloseConnection();
                Connection.Dispose();
            }
        }

        /// <summary>
        /// Releases the data adapter
        /// </summary>
        protected void ReleaseDataAdapter()
        {
            if (DataAdapter != null)
                DataAdapter.Dispose();
        }
        
        /// <summary>
        /// Disposes of update commands.
        /// </summary>
        private void DisposeOfUpdateCommands()
        {
            if (DeleteCommand != null)
                DeleteCommand.Dispose();

            if (InsertCommand != null)
                InsertCommand.Dispose();

            if (UpdateCommand != null)
                UpdateCommand.Dispose();
        }

        #endregion Disposal methods

		#region Update methods
		
		/// <summary>
		/// Updates records in the current table using transactions.
		/// </summary>
		/// <param name="table">Data Table.</param>
        /// <param name="transaction">DbTransaction.</param>
		/// <exception cref="DataLayerException">DataLayerException.</exception>
		/// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
		public void Save(DataTable table, DbTransaction transaction)
		{	
			try
			{
				if (table == null)
					return;
					
                CreateUpdateCommands(transaction);
				DataAdapter.Update(table);
			}
			catch (Exception ex)
			{
				StringBuilder sb = new StringBuilder();
				sb.Append(ex.Message + " An error occurred while updating table '" + TableName + "'.");
				
				if (ex.Message.ToLower().Contains("optimistic concurrency"))
				{
					sb.Append(" The update failed due to a concurrency exception. This means than in the time between when you read the data from the database and updated it, another user updated the same record.");
					DBConcurrencyException dbConcurrencyException = new DBConcurrencyException(sb.ToString(), ex);
					throw dbConcurrencyException;
				}
				else
					HandleException(ex, sb.ToString());
			}
			finally
			{
                DisposeOfUpdateCommands();
			}
		}

		/// <summary>
		/// Updates records in the current table.
		/// </summary>
		/// <param name="table">Data Table.</param>
		/// <exception cref="DataLayerException">DataLayerException.</exception>
		/// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
		public void Save(DataTable table)
		{
            Save(table, null);
		}
		
		/// <summary>
        /// Updates records in the current table using transactions.
        /// </summary>
        /// <param name="rows">Collection of data rows</param>
        /// <param name="transaction">DbTransaction.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        public void Save(DataRow[] rows, DbTransaction transaction)
        {
            try
            {
                if (rows.Length == 0)
                    return;

                CreateUpdateCommands(transaction);
                DataAdapter.Update(rows);
            }
            catch (Exception ex)
			{
				StringBuilder sb = new StringBuilder();
				sb.Append(ex.Message + " An error occurred while updating table '" + TableName + "'.");
				
				if (ex.Message.ToLower().Contains("optimistic concurrency"))
				{
					sb.Append(" The update failed due to a concurrency exception. This means than in the time between when you read the data from the database and updated it, another user updated the same record.");
					DBConcurrencyException dbConcurrencyException = new DBConcurrencyException(sb.ToString(), ex);
					throw dbConcurrencyException;
				}
				else
					HandleException(ex, sb.ToString());
			}
            finally
            {
                DisposeOfUpdateCommands();
            }
        }

        /// <summary>
        /// Updates records in the current table.
        /// </summary>
        /// <param name="rows">Collection of data rows</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        public void Save(DataRow[] rows)
        {
            Save(rows, null);
        }
		
				/// <summary>
        /// Inserts, updates and deletes rows in a table
        /// </summary>
        /// <param name="entities">Entity object collection to update in the database.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        public void Save(IEntities entities)
        {
            Save(entities, null);
        }

        /// <summary>
        /// Inserts, updates and deletes rows in a table using a transaction if required.
        /// </summary>
        /// <param name="entities">The entity object collection to update in the database.</param>
        /// <param name="transaction">DbTransaction.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        public void Save(IEntities entities, DbTransaction transaction)
        {
            if (entities == null || entities.Count == 0)
                return;

            for (int i = 0; i < entities.Count; i++)
            {
                IEntity entity = (IEntity)entities[i];
                Save(entity, transaction, true);
            }
        }

        /// <summary>
        /// Inserts, updates and deletes a row in a table.
        /// </summary>
        /// <param name="entity">The entity object to update in the database.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        public void Save(IEntity entity)
        {
            Save(entity, null, false);
        }

        /// <summary>
        /// Inserts, updates and deletes a row in a table using a transaction if required.
        /// </summary>
        /// <param name="entity">The entity object to update in the database.</param>
        /// <param name="transaction">DbTransaction.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        public void Save(IEntity entity, DbTransaction transaction)
        {
            Save(entity, transaction, false);
        }

        /// <summary>
        /// Inserts, updates and deletes a row in a table using a transaction if required.
        /// </summary>
        /// <param name="entity">The entity object to update in the database.</param>
        /// <param name="transaction">DbTransaction.</param>
        /// <param name="multiple">Indicates whether multiple entities are being update or a single entity.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        /// <exception cref="DBConcurrencyException">DBConcurrencyException.</exception>
        private void Save(IEntity entity, DbTransaction transaction, bool multiple)
        {
            if (entity == null)
                return;

            switch (entity.EntityState)
            {
                case EntityState.New:
                    InsertEntity(entity, transaction);
                    break;
                case EntityState.Existing:
                    if (entity.HasChanges)
                        UpdateEntity(entity, transaction);
                    break;
                case EntityState.Deleted:
                    DeleteEntity(entity, transaction);
                    if (!multiple)
                        entity = null;
                    break;
            }
        }
        
        /// <summary>
        /// Inserts a new record using a transaction if required.
        /// </summary>
        /// <param name="entity">The table entity object to insert into the database.</param>
        /// <param name="transaction">DbTransaction.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected virtual void InsertEntity(IEntity entity, DbTransaction transaction)
        {
            try
            {
                CreateInsertCommand(entity, transaction);

                if (InsertCommand == null)
                    throw new Exception("The insert command has not been created.");
                
                ExecuteNonQuery(InsertCommand, transaction);

                if (!CheckParameterExists(InsertCommand, "RETURN_VALUE") || GetParameterValue<int>(InsertCommand, "RETURN_VALUE") == 0)
                {
                    entity.SetExisting();
                    entity.HasChanges = false;
                }
                else
                    throw new Exception("The record was not successfuly inserted into table '" + TableName + "'.");
            }
            catch (DbHelperException ex)
            {
                HandleException(ex, ex.Message + " An error occurred while either trying to set or retrieve a parameter value.");
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(ex.Message);
                
                if (InsertCommand.CommandType == CommandType.StoredProcedure && !string.IsNullOrEmpty(InsertCommand.CommandText))
                    sb.Append(" An error occurred during the execution of stored procedure '" + InsertCommand.CommandText + "'.");
                    
                sb.Append(" An exception occurred while trying to insert a record into table '" + TableName + "'.");
                HandleException(ex, sb.ToString());
            }
            finally
            {
                ReleaseCommand(InsertCommand);
            }
        }

        /// <summary>
        /// Updates a record using a transaction if required.
        /// </summary>
        /// <param name="entity">Entity object</param>
        /// <param name="transaction">Transaction</param>
        protected virtual void UpdateEntity(IEntity entity, DbTransaction transaction)
        {
            try
            {
                CreateUpdateCommand(entity, transaction);
                ExecuteNonQuery(UpdateCommand, transaction);

                if (!CheckParameterExists(UpdateCommand, "RETURN_VALUE") || GetParameterValue<int>(UpdateCommand, "RETURN_VALUE") == 0)
                    entity.HasChanges = false;
                else
                    throw new Exception("The record was not successfuly updated in table '" + TableName + "'.");
            }
            catch (DbHelperException ex)
            {
                HandleException(ex, ex.Message + " An error occurred while either trying to set or retrieve a parameter value.");
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(ex.Message);
                
                if (UpdateCommand.CommandType == CommandType.StoredProcedure && !string.IsNullOrEmpty(UpdateCommand.CommandText))
                    sb.Append(" An error occurred during the execution of stored procedure '" + UpdateCommand.CommandText + "'.");
                    
                sb.Append(" An exception occurred while trying to update a record in table '" + TableName + "'.");

                if (ex.Message.ToLower().Contains("optimistic concurrency"))
                {
                    sb.Append(" The update failed due to a concurrency exception. This means than in the time between when you read the data from the database and updated it, another user updated the same record.");
                    DBConcurrencyException dbConcurrencyException = new DBConcurrencyException(sb.ToString(), ex);
                    throw dbConcurrencyException;
                }
                else
                    HandleException(ex, sb.ToString());
            }
            finally
            {
                ReleaseCommand(UpdateCommand);
            }
        }

        /// <summary>
        /// Deletes a record using a transaction if required.
        /// </summary>
        /// <param name="entity">Entity object</param>
        /// <param name="transaction">Transaction</param>
        protected virtual void DeleteEntity(IEntity entity, DbTransaction transaction)
        {
			try
			{
				CreateDeleteCommand(entity, transaction);
				ExecuteNonQuery(DeleteCommand, transaction);

				if (CheckParameterExists(DeleteCommand, "RETURN_VALUE") && GetParameterValue<int>(DeleteCommand, "RETURN_VALUE") != 0)
					throw new Exception("The record was not successfuly deleted.");
			}
			catch (DbHelperException ex)
			{
				HandleException(ex, ex.Message + " An error occurred while either trying to set or retrieve a parameter value.");
			}
			catch (Exception ex)
			{
				StringBuilder sb = new StringBuilder();
				sb.Append(ex.Message);
				
				if (DeleteCommand.CommandType == CommandType.StoredProcedure && !string.IsNullOrEmpty(DeleteCommand.CommandText))
                    sb.Append(" An error occurred during the execution of stored procedure '" + DeleteCommand.CommandText + "'.");
                    
                sb.Append(" An exception occurred while trying to delete a record in table '" + TableName + "'.");

                if (ex.Message.ToLower().Contains("optimistic concurrency"))
                {
                    sb.Append(" The update failed due to a concurrency exception. This means than in the time between when you read the data from the database and updated it, another user updated the same record.");
                    DBConcurrencyException dbConcurrencyException = new DBConcurrencyException(sb.ToString(), ex);
                    throw dbConcurrencyException;
                }
                else
                    HandleException(ex, sb.ToString());
			}
			finally
			{
				ReleaseCommand(DeleteCommand);
			}
        } 
		
		#endregion Update methods

        #region Transaction methods

        /// <summary>
        /// Gets a new transaction.
        /// </summary>
        /// <returns>DbTransaction.</returns>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        public DbTransaction CreateTransaction()
        {
            DbTransaction transaction;

            try
            {
                transaction = DBHelper.CreateTransaction(Connection);
            }
            catch (DbHelperException ex)
            {
                throw new DataLayerException(ex.Message, ex);
            }
            
            return transaction;
        }

        /// <summary>
        /// Gets a new transaction.
        /// </summary>
        /// <param name="transactionName">The name of the transaction.</param>
        /// <returns>DbTransaction.</returns>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        public DbTransaction CreateTransaction(string transactionName)
        {
            DbTransaction transaction;

            try
            {
                transaction = DBHelper.CreateTransaction(Connection, transactionName);
            }
            catch (DbHelperException ex)
            {
                throw new DataLayerException(ex.Message, ex);
            }
            
            return transaction;
        }

        /// <summary>
        /// Gets a new transaction.
        /// </summary>
        /// <param name="isolationLevel">The isolation level to use.</param>
        /// <returns>DbTransaction.</returns>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        public DbTransaction CreateTransaction(IsolationLevel isolationLevel)
        {
            DbTransaction transaction;

            try
            {
                transaction = DBHelper.CreateTransaction(Connection, isolationLevel);
            }
            catch (DbHelperException ex)
            {
                throw new DataLayerException(ex.Message, ex);
            }
            
            return transaction;
        }

		/// <summary>
		/// Gets a new transaction.
		/// </summary>
        /// <param name="isolationLevel">The isolation level to use.</param>
        /// <param name="transactionName">The name of the transaction.</param>
		/// <returns>DbTransaction.</returns>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        public DbTransaction CreateTransaction(IsolationLevel? isolationLevel, string transactionName)
		{
            DbTransaction transaction;

            try
            {
                transaction = DBHelper.CreateTransaction(Connection, isolationLevel, transactionName);
            }
            catch (DbHelperException ex)
            {
                throw new DataLayerException(ex.Message, ex);
            }
            
            return transaction;
		}

		/// <summary>
		/// Commits a transaction.
		/// </summary>
        /// <param name="transaction">DbTransaction.</param>
		/// <exception cref="DataLayerException">DataLayerException.</exception>
		public void CommitTransaction(DbTransaction transaction)
		{
			try
			{
				if (transaction != null)
                {
                    transaction.Commit();
                    CloseConnection();
                }
			}
			catch (Exception ex)
			{
				HandleException(ex, ex.Message + " An unexpected error occured while trying to commit the transaction.");
			}
			finally
			{
				CloseConnection();
			}
		}

		/// <summary>
		/// Rollsback a transactoin.
		/// </summary>
        /// <param name="transaction">DbTransaction.</param>
		/// <exception cref="DataLayerException">DataLayerException</exception>
		public void RollbackTransaction(DbTransaction transaction)
		{
			try
			{
				if (transaction != null)
                {
                    transaction.Rollback();
                    CloseConnection();
                }
			}
			catch (Exception ex)
			{
				HandleException(ex, ex.Message + " An unexpected error occured while trying to roll back the transaction.");
			}
			finally
			{
				CloseConnection();
			}
		}
		
		/// <summary>
        /// Disposes of a transaction.
        /// </summary>
        /// <param name="transaction">DbTransaction.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        public void DisposeOfTransaction(DbTransaction transaction)
        {
            try
            {
                if (transaction != null)
                {
                    CloseConnection();
                    transaction.Dispose();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex, ex.Message + " An unexpected error occured while trying to dispose of the transaction.");
            }
        }

        #endregion Transaction methods

        #region Connection methods
        
        /// <summary>
		/// Gets the connection string.
		/// </summary>
        /// <exception cref="ConfigurationErrorsException">ConfigurationErrorsException.</exception>
		private string GetConnectionString()
		{
            string connectionKeyName = Database + "_Connection";

            if (ConfigurationManager.ConnectionStrings[connectionKeyName] == null)
                throw new ConfigurationErrorsException("The connection string setting for key '" + connectionKeyName + "' could not be found.");

            return ConfigurationManager.ConnectionStrings[connectionKeyName].ConnectionString.Trim();
		}

        /// <summary>
        /// Opens the database connection.
        /// </summary>
        protected void OpenConnection()
        {
            try
            {
                if (Connection != null)
                {
                    if (Connection.State != ConnectionState.Open)
                        Connection.Open();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex, ex.Message + " An unexpected error occured while trying to open the connection.");
            }
        }

        /// <summary>
        /// Closes the database connection.
        /// </summary>
        protected void CloseConnection()
        {
			try
			{
				if (Connection != null)
				{
					if (Connection.State != ConnectionState.Closed)
						Connection.Close();
				}
            }
            catch (Exception ex)
            {
                HandleException(ex, ex.Message + " An unexpected error occured while trying to close the connection.");
            }
        }

        #endregion Connection methods
        
        #region Load methods

        
        /// <summary>
        /// Populates an entity collection.
        /// </summary>
        /// <param name="commandType">Command type.</param>
        /// <param name="commandText">Command text</param>
        /// <returns>IEntities.</returns>
        /// <typeparam name="TEntitiesType">Type that is of IEntities.</typeparam>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected TEntitiesType Load<TEntitiesType>(CommandType commandType, string commandText) where TEntitiesType : IEntities
        {
            return LoadEntities<TEntitiesType>(commandType, commandText, null, null);
        }

        /// <summary>
        /// Populates an entity collection.
        /// </summary>
        /// <param name="commandText">Command text</param>
        /// <returns>IEntities.</returns>
        /// <typeparam name="TEntitiesType">Type that is of IEntities.</typeparam>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected TEntitiesType Load<TEntitiesType>(string commandText) where TEntitiesType : IEntities
        {
            return LoadEntities<TEntitiesType>(CommandType.StoredProcedure, commandText, null, null);
        }

        /// <summary>
        /// Populates an entity collection.
        /// </summary>
        /// <param name="commandType">Command type.</param>
        /// <param name="commandText">Command text</param>
        /// <param name="parameters">Parameters.</param>
        /// <returns>TEntitiesType.</returns>
        /// <typeparam name="TEntitiesType">Type that is of IEntities.</typeparam>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected TEntitiesType Load<TEntitiesType>(CommandType commandType, string commandText, DataParameters parameters) where TEntitiesType : IEntities
        {
            return LoadEntities<TEntitiesType>(commandType, commandText, parameters, null);
        }

        /// <summary>
        /// Populates an entity collection.
        /// </summary>
        /// <param name="commandText">Command text</param>
        /// <param name="parameters">Parameters.</param>
        /// <returns>TEntitiesType.</returns>
        /// <typeparam name="TEntitiesType">Type that is of IEntities.</typeparam>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected TEntitiesType Load<TEntitiesType>(string commandText, DataParameters parameters) where TEntitiesType : IEntities
        {
            return LoadEntities<TEntitiesType>(CommandType.StoredProcedure, commandText, parameters, null);
        }

        /// <summary>
        /// Populates an entity collection.
        /// </summary>
        /// <param name="commandType">Command type.</param>
        /// <param name="commandText">Command text</param>
        /// <param name="parameters">Parameters.</param>
        /// <param name="buildEntitiesDelegate">BuildEntitiesDelegate.</param>
        /// <returns>TEntitiesType.</returns>
        /// <typeparam name="TEntitiesType">Type that is of IEntities.</typeparam>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected TEntitiesType Load<TEntitiesType>(CommandType commandType, string commandText, DataParameters parameters, BuildEntitiesDelegate buildEntitiesDelegate) where TEntitiesType : IEntities
        {
            return LoadEntities<TEntitiesType>(commandType, commandText, parameters, buildEntitiesDelegate);
        }

        /// <summary>
        /// Populates an entity collection.
        /// </summary>
        /// <param name="commandText">Command text</param>
        /// <param name="parameters">Parameters.</param>
        /// <param name="buildEntitiesDelegate">BuildEntitiesDelegate.</param>
        /// <returns>TEntitiesType.</returns>
        /// <typeparam name="TEntitiesType">Type that is of IEntities.</typeparam>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected TEntitiesType Load<TEntitiesType>(string commandText, DataParameters parameters, BuildEntitiesDelegate buildEntitiesDelegate) where TEntitiesType : IEntities
        {
            return LoadEntities<TEntitiesType>(CommandType.StoredProcedure, commandText, parameters, buildEntitiesDelegate);
        }

        /// <summary>
        /// Populates an entity collection.
        /// </summary>
        /// <param name="commandType">Command type.</param>
        /// <param name="commandText">Command text</param>
        /// <param name="parameters">Parameters.</param>
        /// <param name="buildEntitiesDelegate">BuildEntitiesDelegate.</param>
        /// <returns>TEntitiesType.</returns>
        /// <typeparam name="TEntitiesType">Type that is of IEntities.</typeparam>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        private TEntitiesType LoadEntities<TEntitiesType>(CommandType commandType, string commandText, DataParameters parameters, BuildEntitiesDelegate buildEntitiesDelegate) where TEntitiesType : IEntities
        {
            IEntities entities = null;

            try
            {
                if (commandType == CommandType.StoredProcedure)
                {
                    if (string.IsNullOrEmpty(commandText))
                        throw new DataLayerException("The stored procedure name is empty.");

                    PrepareStoredProcedureCommand(commandText);
                }
                else
                    PrepareCommand(commandText);

                AddParameters(Command, parameters);
                ExecuteReader();
                if (buildEntitiesDelegate == null)
                    entities = BuildEntities();
                else
                    entities = (IEntities)buildEntitiesDelegate.Method.Invoke(this, new object[] { });
                ReleaseReader();
                GetOutputParameterValues(Command, parameters);
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(ex.Message);
                
                if (commandType == CommandType.StoredProcedure && !string.IsNullOrEmpty(commandText))
                    sb.Append(" An error occurred during the execution of stored procedure '" + commandText + "'.");
                    
                sb.Append(" An unexpected error occurred.");
                HandleException(ex, sb.ToString());
            }
            finally
            {
                ReleaseReader();
                ReleaseCommand();
            }

            return (TEntitiesType)entities;
        }

        /// <summary>
        /// Populates a data table.
        /// </summary>
        /// <param name="table">DataTable to populate.</param>
        /// <param name="commandType">Command type.</param>
        /// <param name="commandText">Command text</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected void Load(DataTable table, CommandType commandType, string commandText)
        {
            Load(table, commandType, commandText, null);
        }

        /// <summary>
        /// Populates a data table.
        /// </summary>
        /// <param name="table">DataTable to populate.</param>
        /// <param name="commandText">Command text</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected void Load(DataTable table, string commandText)
        {
            Load(table, CommandType.StoredProcedure, commandText, null);
        }

        /// <summary>
        /// Populates a data table.
        /// </summary>
        /// <param name="table">DataTable to populate.</param>
        /// <param name="commandText">Command text</param>
        /// <param name="parameters">Parameters.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected void Load(DataTable table, string commandText, DataParameters parameters)
        {
            Load(table, CommandType.StoredProcedure, commandText, parameters);
        }

        /// <summary>
        /// Populates a data table.
        /// </summary>
        /// <param name="table">DataTable to populate.</param>
        /// <param name="commandType">Command type.</param>
        /// <param name="commandText">Command text</param>
        /// <param name="parameters">Parameters.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected void Load(DataTable table, CommandType commandType, string commandText, DataParameters parameters)
        {
            try
            {
                if (commandType == CommandType.StoredProcedure)
                {
                    if (string.IsNullOrEmpty(commandText))
                        throw new DataLayerException("The stored procedure name is empty.");

                    PrepareStoredProcedureCommand(commandText);
                }
                else
                    PrepareCommand(commandText);

                AddParameters(Command, parameters);
                ExecuteDataTable(table);
                GetOutputParameterValues(Command, parameters);
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(ex.Message);
                
                if (commandType == CommandType.StoredProcedure && !string.IsNullOrEmpty(commandText))
                    sb.Append(" An error occurred during the execution of stored procedure '" + commandText + "'.");
                    
                sb.Append(" An unexpected error occurred.");
                HandleException(ex, sb.ToString());
            }
            finally
            {
                ReleaseCommand();
            }
        }

        /// <summary>
        /// Populates a DataSet.
        /// </summary>
        /// <param name="dataSet">DataSet to populate.</param>
        /// <param name="commandType">Command type.</param>
        /// <param name="commandText">Command text</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected void Load(DataSet dataSet, CommandType commandType, string commandText)
        {
            Load(dataSet, commandType, commandText, null);
        }

        /// <summary>
        /// Populates a DataSet.
        /// </summary>
        /// <param name="dataSet">DataSet to populate.</param>
        /// <param name="commandText">Command text</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected void Load(DataSet dataSet, string commandText)
        {
            Load(dataSet, CommandType.StoredProcedure, commandText, null);
        }

        /// <summary>
        /// Populates a DataSet.
        /// </summary>
        /// <param name="dataSet">DataSet to populate.</param>
        /// <param name="commandText">Command text</param>
        /// <param name="parameters">Parameters.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected void Load(DataSet dataSet, string commandText, DataParameters parameters)
        {
            Load(dataSet, CommandType.StoredProcedure, commandText, parameters);
        }

        /// <summary>
        /// Populates a DataSet.
        /// </summary>
        /// <param name="dataSet">DataSet to populate.</param>
        /// <param name="commandType">Command type.</param>
        /// <param name="commandText">Command text</param>
        /// <param name="parameters">Parameters.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected void Load(DataSet dataSet, CommandType commandType, string commandText, DataParameters parameters)
        {
            try
            {
                if (commandType == CommandType.StoredProcedure)
                {
                    if (string.IsNullOrEmpty(commandText))
                        throw new DataLayerException("The stored procedure name is empty.");

                    PrepareStoredProcedureCommand(commandText);
                }
                else
                    PrepareCommand(commandText);

                AddParameters(Command, parameters);
                ExecuteDataSet(dataSet);
                GetOutputParameterValues(Command, parameters);
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(ex.Message);
                
                if (commandType == CommandType.StoredProcedure && !string.IsNullOrEmpty(commandText))
                    sb.Append(" An error occurred during the execution of stored procedure '" + commandText + "'.");
                    
                sb.Append(" An unexpected error occurred.");
                HandleException(ex, sb.ToString());
            }
            finally
            {
                ReleaseCommand();
            }
        }


        #endregion Load methods

		#region General methods
		
        /// <summary>
		/// Handles an exception if one has occurred.
		/// </summary>
		/// <param name="exception">Exception that occurred.</param>
		/// <param name="message">Exception messag.e</param>
		/// <exception cref="DataLayerException">DataLayerException.</exception>
		protected void HandleException(Exception exception, string message)
		{
			DataLayerException dataLayerException = new DataLayerException(message, exception);
            throw dataLayerException;
		}
		
		/// <summary>
        /// Gets all columns in the reader
        /// </summary>
        /// <param name="reader">IDataReader</param>
        /// <returns>List of column names</returns>
        protected List<string> GetReaderColumns(IDataReader reader)
        {
            List<string> columns = new List<string>(0);
            for (int ordinal = 0; ordinal < reader.FieldCount; ordinal++)
                columns.Add(reader.GetName(ordinal));
            return columns;
        }

		/// <summary>
        /// Initialises the data access base class.
        /// </summary>
        /// <param name="database">Database to use.</param>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        private void Initialise(Databases database)
        {
            try
            {
				Initialising = true;
				DBHelper = DbHelperFactory.Create(GetDbHelperType());
				
				if (CommandTimeout.HasValue)
					DBHelper.CommandTimeout = CommandTimeout.Value;
					
                Database = database;
                Connection = DBHelper.CreateConnection(GetConnectionString());
                DataAdapter = DBHelper.CreateDataAdapter();
            }
            catch (DbHelperException ex)
            {
                HandleException(ex, ex.Message + " An error occurred while initialising the DataAccessBase class, possible cause invalid connection string.");
            }
            catch (ConfigurationErrorsException ex)
            {
                HandleException(ex, ex.Message + " An error occurred while initialising the DataAccessBase class, one of the configuration settings was either not found or its value was not valid.");
            }
            catch (Exception ex)
            {
                HandleException(ex, ex.Message + " An error occurred while initialising the DataAccessBase class, possible cause invalid connection string.");
            }
            finally
            {
				Initialising = false;
            }
        }
        
        /// <summary>
        /// Builds a typed entity collection.
        /// </summary>
        /// <returns>Returns a populated entity object collection.</returns>
        /// <exception cref="DataLayerException">DataLayerException.</exception>
        protected virtual IEntities BuildEntities()
        {
            throw new DataLayerException("The BuildEntities method has not been implemented.");
        }
        
        /// <summary>
        /// Gets the DbHelperType
        /// </summary>
        /// <exception cref="ConfigurationErrorsException">ConfigurationErrorsException.</exception>
        private DbHelperType GetDbHelperType()
        {
            DbHelperType dbHelperType = DEFAULT_DATABASE_HELPER_TYPE;

            string connectionKeyName = Database + "_Connection";

            if (ConfigurationManager.ConnectionStrings[connectionKeyName] == null)
                throw new ConfigurationErrorsException("The connection string setting for key '" + connectionKeyName + "' could not be found.");

            switch (ConfigurationManager.ConnectionStrings[connectionKeyName].ProviderName)
            {
                case "System.Data.SqlClient":
                    dbHelperType = DbHelperType.SqlServer;
                    break;
            }

            return dbHelperType;
        }
        
        /// <summary>
        /// Dispose method.
        /// </summary>
        public virtual void Dispose()
        {        
        }
        
        #endregion General methods

		#endregion Methods
		
		#region Properties

        /// <summary>
        /// Gets the DBHelper.
        /// </summary>
        private IDbHelper DBHelper
        {
            get
            {
                return _dbHelper;
            }
            set
            {
				_dbHelper = value;
            }
        }

        /// <summary>
        /// Gets or sets the table name.
        /// </summary>
        protected string TableName
        {
            get
            {
                return _tableName;
            }
            set
            {
                _tableName = value;
            }
        }

        /// <summary>
        /// Gets the DBDataAdapter.
        /// </summary>
        protected DbDataAdapter DataAdapter
        {
            get
            {
                return _dataAdapter;
            }
            private set
            {
				_dataAdapter = value;
            }
        }
        
        /// <summary>
        /// Gets the DbDataReader.
        /// </summary>
        protected DbDataReader DataReader
        {
            get
            {
                return _dataReader;
            }
            private set
            {
				_dataReader = value;
            }
        }

        /// <summary>
        /// Gets or sets the DBConnection.
        /// </summary>
        private DbConnection Connection
        {
            get
            {
                return _connection;
            }
            set
            {
				_connection = value;
            }
        }

        /// <summary>
        /// Gets or sets the insert command.
        /// </summary>
        protected DbCommand InsertCommand
        {
            get
            {
                return _insertCommand;
            }
            set
            {
                _insertCommand = value;
            }
        }

        /// <summary>
        /// Gets or sets the update command.
        /// </summary>
        protected DbCommand UpdateCommand
        {
            get
            {
                return _updateCommand;
            }
            set
            {
                _updateCommand = value;
            }
        }

        /// <summary>
        /// Gets or sets the delete command.
        /// </summary>
        protected DbCommand DeleteCommand
        {
            get
            {
                return _deleteCommand;
            }
            set
            {
                _deleteCommand = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the database to use.
        /// </summary>
        protected Databases Database
        {
            get
            {
                return _database;
            }
            set
            {
                _database = value;
                if (!Initialising)
					Connection = DBHelper.CreateConnection(GetConnectionString());
            }
        }

        /// <summary>
        /// Gets or sets the current command object
        /// </summary>
        private DbCommand Command
        {
            get
            {
                return _command;
            }
            set
            {
				_command = value;
            }
        }
		
		/// <summary>
        /// Gets or sets whether the class is initialising
        /// </summary>
        private bool Initialising
		{
			get
			{
				return _initialising;
			}
			set
			{
				_initialising = value;
			}
		}
		
		/// <summary>
        /// Gets the command timeout.
        /// </summary>
        private int? CommandTimeout
        {
			get
			{
                if (ConfigurationManager.AppSettings[AppSettingsKeyPrefix + "Entities_CommandTimeout"] != null)
                {
					int commandTimeout;
					
                    if (int.TryParse(ConfigurationManager.AppSettings[AppSettingsKeyPrefix + "Entities_CommandTimeout"].Trim(), out commandTimeout))
                        return commandTimeout;
                }

                return null;        
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
	
	/// <summary>
    /// Class for stored procedure parameters
    /// </summary>
    public class DataParameter
    {

        #region Members

        private string _name = string.Empty;
        private ParameterDirection _direction = ParameterDirection.Input;
        private object _value;
        private DbType? _dbType;
        private int? _size;
        private byte? _scale;
        private byte? _precision;
        private string _sourceColumn;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public DataParameter()
        {
        }

        /// <summary>
        /// Overriden constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        public DataParameter(string name, object value)
        {
            _name = name;
            _value = value;
        }

        /// <summary>
        /// Overriden constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        /// <param name="dbType">DbType.</param>
        public DataParameter(string name, object value, DbType dbType)
        {
            _name = name;
            _value = value;
            _dbType = dbType;
        }

        /// <summary>
        /// Overriden constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="direction">Direction.</param>
        public DataParameter(string name, object value, DbType dbType, ParameterDirection direction)
        {
            _name = name;
            _value = value;
            _dbType = dbType;
            _direction = direction;
        }

        /// <summary>
        /// Overriden constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="sourceColumn">Source column.</param>
        public DataParameter(string name, object value, DbType dbType, string sourceColumn)
        {
            _name = name;
            _value = value;
            _dbType = dbType;
            _sourceColumn = sourceColumn;
        }

        /// <summary>
        /// Overriden constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="sourceColumn">Source column.</param>
        /// <param name="direction">Direction.</param>
        public DataParameter(string name, object value, DbType dbType, string sourceColumn, ParameterDirection direction)
        {
            _name = name;
            _value = value;
            _dbType = dbType;
            _sourceColumn = sourceColumn;
            _direction = direction;
        }

        /// <summary>
        /// Overriden constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        public DataParameter(string name, object value, DbType dbType, int size)
        {
            _name = name;
            _value = value;
            _dbType = dbType;
            _size = size;
        }

        /// <summary>
        /// Overriden constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        /// <param name="direction">Direction.</param>
        public DataParameter(string name, object value, DbType dbType, int size, ParameterDirection direction)
        {
            _name = name;
            _value = value;
            _dbType = dbType;
            _size = size;
            _direction = direction;
        }

        /// <summary>
        /// Overriden constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        /// <param name="sourceColumn">Source column.</param>
        public DataParameter(string name, object value, DbType dbType, int size, string sourceColumn)
        {
            _name = name;
            _value = value;
            _dbType = dbType;
            _size = size;
            _sourceColumn = sourceColumn;
        }

        /// <summary>
        /// Overriden constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        /// <param name="sourceColumn">Source column.</param>
        /// <param name="direction">Direction.</param>
        public DataParameter(string name, object value, DbType dbType, int size, string sourceColumn, ParameterDirection direction)
        {
            _name = name;
            _value = value;
            _dbType = dbType;
            _size = size;
            _sourceColumn = sourceColumn;
            _direction = direction;
        }

        /// <summary>
        /// Overriden constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        public DataParameter(string name, object value, DbType dbType, byte precision, byte scale)
        {
            _name = name;
            _value = value;
            _dbType = dbType;
            _precision = precision;
            _scale = scale;
        }

        /// <summary>
        /// Overriden constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        /// <param name="direction">Direction.</param>
        public DataParameter(string name, object value, DbType dbType, byte precision, byte scale, ParameterDirection direction)
        {
            _name = name;
            _value = value;
            _dbType = dbType;
            _precision = precision;
            _scale = scale;
            _direction = direction;
        }

        /// <summary>
        /// Overriden constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        /// <param name="sourceColumn">Source column.</param>
        public DataParameter(string name, object value, DbType dbType, byte precision, byte scale,
            string sourceColumn)
        {
            _name = name;
            _value = value;
            _dbType = dbType;
            _precision = precision;
            _scale = scale;
            _sourceColumn = sourceColumn;
        }

        /// <summary>
        /// Overriden constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        /// <param name="sourceColumn">Source column.</param>
        /// <param name="direction">Direction.</param>
        public DataParameter(string name, object value, DbType dbType, byte precision, byte scale,
            string sourceColumn, ParameterDirection direction)
        {
            _name = name;
            _value = value;
            _dbType = dbType;
            _precision = precision;
            _scale = scale;
            _sourceColumn = sourceColumn;
            _direction = direction;
        }

        /// <summary>
        /// Overriden constructor.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        /// <param name="direction">Direction.</param>
        /// <param name="dbType">DbType.</param>
        /// <param name="size">Size.</param>
        /// <param name="precision">Precision.</param>
        /// <param name="scale">Scale.</param>
        /// <param name="sourceColumn">Source column.</param>
        public DataParameter(string name, object value, ParameterDirection direction,
            DbType dbType, int size, byte precision, byte scale, string sourceColumn)
        {
            _name = name;
            _value = value;
            _direction = direction;
            _dbType = dbType;
            _size = size;
            _precision = precision;
            _scale = scale;
            _sourceColumn = sourceColumn;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the parameter name.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Gets or set the parameter value.
        /// </summary>
        public object Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        /// <summary>
        /// Gets or sets the parameter direction.
        /// </summary>
        public ParameterDirection Direction
        {
            get
            {
                return _direction;
            }
            set
            {
                _direction = value;
            }
        }

        /// <summary>
        /// Gets or sets the parameter DbType.
        /// </summary>
        public DbType? DbType
        {
            get
            {
                return _dbType;
            }
            set
            {
                _dbType = value;
            }
        }

        /// <summary>
        /// Gets or sets the parameter size.
        /// </summary>
        public int? Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }

        /// <summary>
        /// Gets or sets the parameter scale.
        /// </summary>
        public byte? Scale
        {
            get
            {
                return _scale;
            }
            set
            {
                _scale = value;
            }
        }

        /// <summary>
        /// Gets or sets the parameter precision.
        /// </summary>
        public byte? Precision
        {
            get
            {
                return _precision;
            }
            set
            {
                _precision = value;
            }
        }

        /// <summary>
        /// Gets or sets the parameter source column.
        /// </summary>
        public string SourceColumn
        {
            get
            {
                return _sourceColumn;
            }
            set
            {
                _sourceColumn = value;
            }
        }

        #endregion Properties

    }

    /// <summary>
    /// Class for procedure parameters
    /// </summary>
    public class DataParameters : List<DataParameter>
    {
		
		#region Methods
		
        /// <summary>
        /// Gets a parameter by its name.
        /// </summary>
        /// <param name="name">Parameter name.</param>
        /// <returns>DataParameter or null if it wasn't found.</returns>
        public DataParameter this[string name]
        {
            get
            {
                foreach (DataParameter dataParameter in this)
                {
                    if (dataParameter.Name == name)
                        return dataParameter;
                }

                return null;
            }
        }
        
        /// <summary>
        /// Gets a parameters value.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <returns>Parameter value.</returns>
        /// <typeparam name="T">Type</typeparam>
        public T GetParameterValue<T>(string parameterName)
        {
            DataParameter parameter = this[parameterName];
            if (parameter == null)
                throw new Exception("The parameter with the name '" + parameterName + "' could not be found.");

            return (parameter.Value == null ? default(T) : (T)parameter.Value);
        }
        
        /// <summary>
        /// Gets a parameters value.
        /// </summary>
        /// <param name="parameterName">Parameter name.</param>
        /// <returns>Parameter value.</returns>
        public object GetParameterValue(string parameterName)
        {
            DataParameter parameter = this[parameterName];
            if (parameter == null)
                throw new Exception("The parameter with the name '" + parameterName + "' could not be found.");

            return parameter.Value;
        }
        
        #endregion Methods
        
    }
}