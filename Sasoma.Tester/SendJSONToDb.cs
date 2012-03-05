using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace Tester
{
    enum DataCategory
    {
        Datatypes,
        Types,
        Properties
    }

    public partial class SendJSONToDb : Form
    {
        static DataTable typesTable;
        static DataTable propertiesTable;

        public SendJSONToDb()
        {
            InitializeComponent();

            typesTable = DatatableManager.Create(DatatableManager.TypesColumnNames);
            typesTable.TableName = "typesTable";
            propertiesTable = DatatableManager.Create(DatatableManager.PropertiesColumnNames);
            propertiesTable.TableName = "propertiesTable";
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

        private void button1_Click(object sender, EventArgs e)
        {
            ParseProperties();
            ParseDataTypes();
            ParseTypes();
            DumpData(typesTable, "Types");
            DumpData(propertiesTable, "Properties");
        }

        private void ParseProperties()
        {
            string filePath = @"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\JSON\FilesFragments\properties.txt";
            string text = File.ReadAllText(filePath);
            ParseAndGenerate(text, DataCategory.Properties);
        }

        private void ParseDataTypes()
        {
            string filePath = @"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\JSON\FilesFragments\datatypes.txt";
            string text = File.ReadAllText(filePath);
            ParseAndGenerate(text, DataCategory.Datatypes);
        }

        private void ParseTypes()
        {
            string filePath = @"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\JSON\FilesFragments\types.txt";
            string text = File.ReadAllText(filePath);
            ParseAndGenerate(text, DataCategory.Types);
        }

        private static void ParseAndGenerate(string text, DataCategory dataCategory)
        {
            string[] items = text.Split(new string[] { "}," }, StringSplitOptions.None);
            for (int i = 0; i < items.Length; i++)
            {
                string[] lines = items[i].Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                switch (dataCategory)
                {
                    case DataCategory.Datatypes:
                        GenerateDataTypes(lines, true);
                        break;
                    case DataCategory.Types:
                        GenerateDataTypes(lines, false);
                        break;
                    case DataCategory.Properties:
                        GenerateProperties(lines);
                        break;
                }
            }
        }

        private static void GenerateProperties(string[] lines)
        {
            DataRow dr = propertiesTable.NewRow();
            string currentItem = String.Empty;
            for (int i = 0; i < lines.Length; i++)
            {
                currentItem = lines[i].Trim(new char[] { '"', ' ' });

                if (currentItem.StartsWith("comment\"", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["comment"] = GetProperty(currentItem);
                }

                if (currentItem.StartsWith("comment_plain", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["comment_plain"] = GetProperty(currentItem);
                }

                if (currentItem.StartsWith("domains", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["domains"] = GetPropertyArray(currentItem);
                }

                if (currentItem.StartsWith("id", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["id"] = GetProperty(currentItem);
                }

                if (currentItem.StartsWith("label", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["label"] = GetProperty(currentItem);
                }

                if (currentItem.StartsWith("ranges", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["ranges"] = GetPropertyArray(currentItem);
                }
            }

            propertiesTable.Rows.Add(dr);
        }

        private static void GenerateDataTypes(string[] lines, bool isDataType)
        {
            DataRow dr = typesTable.NewRow();

            string currentItem = String.Empty;
            for (int i = 0; i < lines.Length; i++)
            {
                currentItem = lines[i].Trim(new char[] { '"', ' ' });

                if (currentItem.StartsWith("ancestors", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["ancestors"] = GetPropertyArray(currentItem);
                }

                if (currentItem.StartsWith("comment\"", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["comment"] = GetProperty(currentItem);
                }

                if (currentItem.StartsWith("comment_plain", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["comment_plain"] = GetProperty(currentItem);
                }

                if (currentItem.StartsWith("id", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["id"] = GetProperty(currentItem);
                }

                if (currentItem.StartsWith("instances", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["instances"] = GetPropertyArray(currentItem);
                }

                if (currentItem.StartsWith("label", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["label"] = GetProperty(currentItem);
                }

                if (currentItem.StartsWith("properties", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["properties"] = GetPropertyArray(currentItem);
                }

                if (currentItem.StartsWith("specific_properties", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["specific_properties"] = GetPropertyArray(currentItem);
                }
                if (currentItem.StartsWith("subtypes", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["subtypes"] = GetPropertyArray(currentItem);
                }
                if (currentItem.StartsWith("supertypes", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["supertypes"] = GetPropertyArray(currentItem);
                }
                if (currentItem.StartsWith("url", StringComparison.InvariantCultureIgnoreCase))
                {
                    dr["url"] = GetProperty(currentItem);
                }
            }
            dr["IsDataType"] = isDataType;
            typesTable.Rows.Add(dr);
        }

        private static string GetProperty(string currentItem)
        {
            string[] bothSides = currentItem.Split(new char[]{':'}, 2);
            string item = bothSides[1].Replace("\"", String.Empty);
            item = item.Trim();
            item = item.Trim(new char[]{','});
            if (item == String.Empty)
                return null;

            return item;
        }

        private static string GetPropertyArray(string currentItem)
        {
            string[] items = null;
            string[] bothSides = currentItem.Split(new char[] { ':' }, 2);
            string compoundRelations = GetTextBetweenBrackets(bothSides[1]);
            compoundRelations = compoundRelations.Replace(" ", String.Empty);
            if (compoundRelations.Length > 0)
                items = compoundRelations.Replace("\"", String.Empty).Split(',');
            if (items != null)
                return String.Join(",", items);
            return null;
        }

        private static string GetTextBetweenBrackets(string input)
        {
            string pattern = @"(?<=\[)(.*?)(?=\])";
            Match output = Regex.Match(input, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
            return output.Value;
        }

        private void DumpData(DataTable dataTable, string destinationTableName)
        {
            //Open a connection with destination database;
            using (SqlConnection connection = GetConnection("Microdata"))
            {
                connection.Open();
                //Open bulkcopy connection.
                using (SqlBulkCopy bulkcopy = new SqlBulkCopy(connection))
                {
                    bulkcopy.DestinationTableName = destinationTableName;

                    try
                    {
                        bulkcopy.WriteToServer(dataTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                connection.Close();
            }
        }

    }
}
