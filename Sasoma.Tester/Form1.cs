using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer;
using System.Data.SqlClient;

namespace Tester
{
    public partial class Form1 : Form
    {
        bool isJumpToNextIndex = false;
        int prefixIndex = 0;
        string prefix = String.Empty;
        string tableName = String.Empty;
        string[] prefixes = new string[] { "datatypes", "properties", "types" };
        DataTableCollection dataTableCollection;
        DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            DataSet ds = ReadXML(@"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\XMLSchemas\microdata.xml");
            string microdataXSD = ds.GetXmlSchema();

            string xsdDir = @"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\XSD\";
            File.WriteAllText(xsdDir + "microdata.xsd", microdataXSD);

            lblStatus.Text = "Done";
        }

        private DataSet ReadXML(string xmlPath)
        {
            DataSet ds = new DataSet();
            // Create new FileStream with which to read the schema.
            System.IO.FileStream fsReadXml = new System.IO.FileStream(xmlPath, System.IO.FileMode.Open);
            try
            {
                ds.ReadXml(fsReadXml);
            }
            catch (Exception ex)
            {
                //Response.Write(ex.ToString());
            }
            finally
            {
                fsReadXml.Close();
            }
            return ds;
        }

        private void btnCreateDatabaseSchema_Click(object sender, EventArgs e)
        {
            DataSet ds = ReadXML(@"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\XMLSchemas\microdata.xml");
            CreateDatabaseSchema(ds);
        }

        private void btnCreateXML_Click(object sender, EventArgs e)
        {
            string xmlDir = @"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\XMLSchemas\";
            string jsonText = File.ReadAllText(@"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\JSON\all.json");
            XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(jsonText, "microdata");
            doc.Save(xmlDir + "microdata.xml");
        }

        private void btnDumpDataToDb_Click(object sender, EventArgs e)
        {
            DataSet ds = ReadXML(@"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\XMLSchemas\microdata.xml");
            DumpData(ds);
        }

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

        private void CreateDatabaseSchema(DataSet ds)
        {
            SqlConnection connection = GetConnection(null);
            //SMO Server object setup with SQLConnection.
            Server server = new Server(new ServerConnection(connection));
            //Create a new SMO Database giving server object and database name
            Database db = new Database();
            if (server.Databases.Contains("Microdata"))
            {
                server.Databases["Microdata"].Drop();
            }
            db = new Database(server, "Microdata");
            db.Create();
            //Set Database to the newly created database
            db = server.Databases["Microdata"];

            dataTableCollection = ds.Tables;
            for (int i = 0; i < dataTableCollection.Count; i++)
            {
                //Create a new SMO table
                dataTable = dataTableCollection[i];
                tableName = dataTable.TableName;
                isJumpToNextIndex = false;
                for (int j = prefixIndex; j < prefixes.Length; j++)
                {
                    if (prefixes[j] == tableName)
                    {
                        prefix = tableName + "_";
                        isJumpToNextIndex = true;
                        prefixIndex = j;
                        break;
                    }
                }
                if (isJumpToNextIndex)
                    continue;

                Table TestTable = new Table(db, prefix + tableName);

                //server.Databases["Microdata"].Tables.Contains(ds.Tables[i].TableName)
                //SMO Column object referring to destination table.
                Column tempC = new Column();

                //Add the column names and types from the datatable into the new table
                //Using the columns name and type property
                foreach (DataColumn dc in dataTable.Columns)
                {
                    //Create columns from datatable column schema
                    tempC = new Column(TestTable, dc.ColumnName);
                    tempC.DataType = GetDataType(dc.DataType.ToString());

                    TestTable.Columns.Add(tempC);
                }

                ////Create a primary key index
                //Index index = new Index(TestTable, "Id");
                //index.IndexKeyType = IndexKeyType.DriPrimaryKey;
                //index.IndexedColumns.Add(new IndexedColumn(index, "Id"));
                //TestTable.Indexes.Add(index);

                //Create the Destination Table
                TestTable.Create();
            }
            connection.Close();
        }

        private DataType GetDataType(string dataType)
        {
            DataType DTTemp = null;

            switch (dataType)
            {
                case ("System.Decimal"):
                    DTTemp = DataType.Decimal(2, 18);
                    break;
                case ("System.String"):
                    DTTemp = DataType.VarChar(500);
                    break;
                case ("System.Int32"):
                    DTTemp = DataType.Int;
                    break;
            }
            return DTTemp;
        }

        private void DumpData(DataSet ds)
        {
            dataTableCollection = ds.Tables;
            //Open a connection with destination database;
            using (SqlConnection connection = GetConnection("Microdata"))
            {
                connection.Open();
                for (int i = 0; i < dataTableCollection.Count; i++)
                {
                    dataTable = dataTableCollection[i];
                    tableName = dataTable.TableName;
                    isJumpToNextIndex = false;
                    for (int j = prefixIndex; j < prefixes.Length; j++)
                    {
                        if (prefixes[j] == tableName)
                        {
                            prefix = tableName + "_";
                            isJumpToNextIndex = true;
                            prefixIndex = j;
                            break;
                        }
                    }
                    if (isJumpToNextIndex)
                        continue;

                    //Open bulkcopy connection.
                    using (SqlBulkCopy bulkcopy = new SqlBulkCopy(connection))
                    {
                        //Set destination table name
                        //to table previously created.
                        bulkcopy.DestinationTableName = prefix + tableName;

                        try
                        {
                            bulkcopy.WriteToServer(dataTable);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                connection.Close();
            }
        }

    }
}
