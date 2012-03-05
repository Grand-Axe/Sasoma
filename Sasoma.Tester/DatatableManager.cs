using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tester
{
    internal class DatatableManager
    {
        internal static string[] PropertiesColumnNames = new string[]{"Comment","Comment_Plain","Domains","Id","Label","Ranges"};
        internal static string[] TypesColumnNames = new string[]{"ancestors","Comment","Comment_Plain","Id","Instances","Label","Properties",
                                                            "Specific_Properties","SubTypes","SuperTypes","Url","IsDataType"};

        internal static DataTable Create(string[] columnNames)
        {
            DataTable dt = new DataTable();
            DataColumn dc;
            for (int i = 0; i < columnNames.Length; i++)
            {
                dc = new DataColumn(columnNames[i]);
                dt.Columns.Add(dc);
            }
            return dt;
        }

        internal static DataColumn SetColumnValue(DataRow dr, string columnName, object value)
        {
            dr[columnName] = value;
            return (DataColumn)dr[columnName];
        }

        internal static void AddRow(DataTable dt, DataRow dr)
        {
            dt.Rows.Add(dr);
        }

        internal static void AddRow(DataTable dt, DataRow dr, string[] columnNames, object[] columnValues)
        {
            if (columnNames.Length != columnValues.Length)
                return;

            for (int i = 0; i < columnNames.Length; i++)
            {
                dr[columnNames[i]] = columnValues[i];
            }
            dt.Rows.Add(dr);
        }

        internal static void AddRow(DataTable dt, object[] columnValues)
        {
            DataRow dr = dt.NewRow();
            for (int i = 0; i < columnValues.Length; i++)
            {
                dr[i] = columnValues[i];
            }
            dt.Rows.Add(dr);
        }

        internal static void UpdateRow(DataTable dt, DataRow dr, int columnIndex, object columnValue)
        {
            dr[columnIndex] = columnValue;
        }

        internal static void UpdateRow(DataTable dt, DataRow dr, string columnName, object columnValue)
        {
            dr[columnName] = columnValue;
        }

        internal static void UpdateRow(DataTable dt, DataRow dr, object[] columnValues)
        {
            for (int i = 0; i < columnValues.Length; i++)
            {
                dr[i] = columnValues[i];
            }
        }

        internal static void UpdateRow(DataTable dt, DataRow dr, string[] columnNames, object[] columnValues)
        {
            if (columnNames.Length != columnValues.Length)
                return;

            for (int i = 0; i < columnNames.Length; i++)
            {
                dr[columnNames[i]] = columnValues[i];
            }
        }

        internal static void DeleteRow(DataTable dt, int index)
        {
            dt.Rows.RemoveAt(index);
        }

        internal static void DeleteRow(DataTable dt, DataRow dr)
        {
            dt.Rows.Remove(dr);
        }
    }
}
