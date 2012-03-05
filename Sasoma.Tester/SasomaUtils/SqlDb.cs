using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sasoma.MicrodataBase;
using System.Data.SqlClient;
using System.Data;

namespace Tester.SasomaUtils
{
    internal class SqlDb
    {
        private static SqlConnection GetConnection(string database)
        {
            string connString = String.Empty;
            if (String.IsNullOrEmpty(database))
            {
                connString = "Data Source=asame;Integrated Security=SSPI";
            }
            else
            {
                connString = "Data Source=asame;Integrated Security=SSPI;Initial Catalog = " + database;
            }
            SqlConnection connection = new SqlConnection(connString);
            return connection;
        }
        
        internal static List<TypeDef> GetTypeAll()
        {
            string proc = "GetTypeAll";
            return DbGetMicrodataTypeDefinition(proc, null, null);
        }

        internal static List<PropertyDef> GetPropertiesAll()
        {
            string proc = "GetPropertiesAll";
            return DbGetMicrodataPropertyDefinition(proc, null, null);
        }

        internal static List<PropertyDef> GetTypeProperties(object parameter)
        {
            string proc = "GetTypeProperties";
            string[] parameterNames = new string[] { "typeid" };
            object[] parameterValues = new object[] { parameter };
            return DbGetMicrodataPropertyDefinition(proc, parameterNames, parameterValues);
        }

        internal static List<PropertyDef> GetTypeAncestorPropertiesAll(object parameter)
        {
            string proc = "GetTypeAncestorPropertiesAll";
            string[] parameterNames = new string[] { "typeid" };
            object[] parameterValues = new object[] { parameter };
            return DbGetMicrodataPropertyDefinition(proc, parameterNames, parameterValues);
        }

        internal static List<PropertyDef> GetTypeSpecific_Properties(object parameter)
        {
            string proc = "GetTypeSpecific_Properties";
            string[] parameterNames = new string[] { "typeid" };
            object[] parameterValues = new object[] { parameter };
            return DbGetMicrodataPropertyDefinition(proc, parameterNames, parameterValues);
        }

        internal static List<PropertyDef> DbGetMicrodataPropertyDefinition(string proc, string[] parameterName, object[] parameter)
        {
            List<PropertyDef> microdataPropertyDefinitionCollection = new List<PropertyDef>();
            SqlCommand cmd = GetCommand(proc, parameterName, parameter);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                PropertyDef microdataPropertyDefinitiona = new PropertyDef();
                if (reader["Comment"] != DBNull.Value)
                    microdataPropertyDefinitiona.Comment = reader["Comment"].ToString();
                if (reader["Comment_Plain"] != DBNull.Value)
                    microdataPropertyDefinitiona.Comment_Plain = reader["Comment_Plain"].ToString();
                if (reader["Id"] != DBNull.Value)
                    microdataPropertyDefinitiona.Id = reader["Id"].ToString();
                if (reader["Domains"] != DBNull.Value)
                    microdataPropertyDefinitiona.Domains = reader["Domains"].ToString().Split(',');
                if (reader["Label"] != DBNull.Value)
                    microdataPropertyDefinitiona.Label = reader["Label"].ToString();
                if (reader["Ranges"] != DBNull.Value)
                    microdataPropertyDefinitiona.Ranges = reader["Ranges"].ToString().Split(',');
                if (reader["PropertyId"] != DBNull.Value)
                    microdataPropertyDefinitiona.PropertyId = Convert.ToInt32(reader["PropertyId"]);
                microdataPropertyDefinitionCollection.Add(microdataPropertyDefinitiona);
            }
            cmd.Connection.Close();
            return microdataPropertyDefinitionCollection;
        }


        internal static List<TypeDef> DbGetMicrodataTypeDefinition(string proc, string[] parameterName, object[] parameter)
        {
            List<TypeDef> microdataTypeDefinitionCollection;
            microdataTypeDefinitionCollection = new List<TypeDef>();
            SqlCommand cmd = GetCommand(proc, parameterName, parameter);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TypeDef microdataTypeDefinitiona = new TypeDef();
                if (reader["Ancestors"] != DBNull.Value)
                    microdataTypeDefinitiona.Ancestors = reader["Ancestors"].ToString().Split(',');
                if (reader["Comment"] != DBNull.Value)
                    microdataTypeDefinitiona.Comment = reader["Comment"].ToString();
                if (reader["Comment_Plain"] != DBNull.Value)
                    microdataTypeDefinitiona.Comment_Plain = reader["Comment_Plain"].ToString();
                if (reader["Id"] != DBNull.Value)
                    microdataTypeDefinitiona.Id = reader["Id"].ToString();
                if (reader["Instances"] != DBNull.Value)
                    microdataTypeDefinitiona.Instances = reader["Instances"].ToString().Split(',');
                if (reader["Label"] != DBNull.Value)
                    microdataTypeDefinitiona.Label = reader["Label"].ToString();
                if (reader["Properties"] != DBNull.Value)
                    microdataTypeDefinitiona.Properties = reader["Properties"].ToString().Split(',');
                if (reader["Specific_Properties"] != DBNull.Value)
                    microdataTypeDefinitiona.Specific_Properties = reader["Specific_Properties"].ToString().Split(',');
                if (reader["SubTypes"] != DBNull.Value)
                    microdataTypeDefinitiona.SubTypes = reader["SubTypes"].ToString().Split(',');
                if (reader["SuperTypes"] != DBNull.Value)
                    microdataTypeDefinitiona.SuperTypes = reader["SuperTypes"].ToString().Split(',');
                if (reader["TypeId"] != DBNull.Value)
                    microdataTypeDefinitiona.TypeId = Convert.ToInt32(reader["TypeId"]);
                if (reader["Url"] != DBNull.Value)
                    microdataTypeDefinitiona.Url = reader["Url"].ToString();
                if (reader["IsDataType"] != DBNull.Value)
                    microdataTypeDefinitiona.IsDataType = Convert.ToBoolean(reader["IsDataType"]);
                microdataTypeDefinitionCollection.Add(microdataTypeDefinitiona);
            }
            cmd.Connection.Close();
            return microdataTypeDefinitionCollection;
        }

        private static SqlCommand GetCommand(string proc, string[] parameterNames, object[] parameterValues)
        {
            SqlConnection conn = GetConnection("microdata");
            SqlCommand cmd = new SqlCommand(proc, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameterValues != null && parameterNames != null)
            {
                if (parameterValues.Length > 0 && parameterNames.Length > 0)
                {
                    for (int i = 0; i < parameterValues.Length; i++)
                    {
                        if (parameterValues[i] != null)
                        {
                            SqlParameter sqlParam = new SqlParameter(parameterNames[i], parameterValues[i]);
                            cmd.Parameters.Add(sqlParam);
                        }
                    }
                }
            }
            return cmd;
        }

    }
}