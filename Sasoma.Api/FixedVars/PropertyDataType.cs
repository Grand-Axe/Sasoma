using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;

namespace Sasoma.Api.FixedVars
{
    public class PropertyDataType
    {
        /// <summary>
        /// 
        /// </summary>
        internal static Dictionary<int, string> DataTypes = new Dictionary<int, string>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyId"></param>
        /// <returns></returns>
        internal static string GetTypeName(int propertyId)
        {
            if (DataTypes.Count == 0)
                Populate();

            string typeName = null;
            typeName = DataTypes[propertyId];
            return typeName;
        }

        /// <summary>
        /// 
        /// </summary>
        internal static void Populate()
        {
            if (DataTypes.Count == 0)
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("Sasoma.Api.PropertyDatatype.txt"));

                string line;
                string[] vals = { "", "" };
                while ((line = reader.ReadLine()) != null)
                {
                    vals = line.Split('|');
                    DataTypes.Add(Convert.ToInt32(vals[0]), vals[1]);
                }
            }
        }
    }
}
