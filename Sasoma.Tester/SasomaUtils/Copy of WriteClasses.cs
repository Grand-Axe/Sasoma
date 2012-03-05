using System;
using System.Collections.Generic;
using Sasoma.MicrodataBase;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
using System.Resources;
using System.Reflection;

namespace Tester.SasomaUtils
{
    internal class WriteClasses
    {
        internal static string sufix = "_Core";
        static string parent = String.Empty;

        internal static void Write()
        {
            List<TypeDef> types = SqlDb.GetTypeAll();
            for (int i = 0; i < 11; i++)
            //for (int i = 0; i < types.Count; i++)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("using System;" + Environment.NewLine);
                sb.Append("using System.Globalization;" + Environment.NewLine);
                sb.Append("using System.Collections.Generic;" + Environment.NewLine + Environment.NewLine);
                sb.Append("using Sasoma.Utils;" + Environment.NewLine);
                sb.Append("using Sasoma.MicrodataBase;" + Environment.NewLine);
                sb.Append("using Sasoma.Languages.Core;" + Environment.NewLine);
                sb.Append("using Sasoma.Microdata.Properties;" + Environment.NewLine + Environment.NewLine);

                //sb.Append("using Sasoma.Languages.Core;" + Environment.NewLine);
                //sb.Append("using Sasoma.Microdata.Properties;" + Environment.NewLine);
                //sb.Append("using System;" + Environment.NewLine);
                //sb.Append("using System.Collections.Generic;" + Environment.NewLine);
                //sb.Append("using Sasoma.MicrodataBase;" + Environment.NewLine);
                //sb.Append("using System.Globalization;" + Environment.NewLine + Environment.NewLine);

                sb.Append("namespace Sasoma.Microdata.Types" + Environment.NewLine);
                sb.Append("{" + Environment.NewLine);

                sb.Append(Tabs(1) + "/// <summary>" + Environment.NewLine);
                sb.Append(Tabs(1) + "/// " + types[i].Comment + Environment.NewLine);
                sb.Append(Tabs(1) + "/// </summary>" + Environment.NewLine);
                string[] ancestors = types[i].Ancestors;
                if (ancestors != null && ancestors.Length > 0)
                {
                    sb.Append(Tabs(1) + "public class " + types[i].Id + sufix + " : " + ancestors[ancestors.Length - 1] + sufix + Environment.NewLine);
                }
                else
                {
                    sb.Append(Tabs(1) + "public class " + types[i].Id + sufix + Environment.NewLine);
                }
                sb.Append(Tabs(1) + "{" + Environment.NewLine);

                sb.Append(Tabs(2) + "//consts are called in the same way as static variables.;" + Environment.NewLine);
                sb.Append(Tabs(2) + "public const int TypeId = " + (types[i].TypeId - 1).ToString() + ";" + Environment.NewLine);
                sb.Append(Tabs(2) + "public const string Id = \"" + types[i].Id + "\";" + Environment.NewLine);
                sb.Append(Tabs(2) + "public readonly string Label =  CultureManager.GetResourceString(\"" + types[i].Label + "\", typeof(" + types[i].Id + sufix + "), Core.BaseName_Types);" + Environment.NewLine);
                sb.Append(Tabs(2) + "public const string Url = \"" + types[i].Url + "\";" + Environment.NewLine);

                string ancestorIds = String.Join(",", GetAncestorIds(types, types[i]));
                if (String.IsNullOrEmpty(ancestorIds))
                {
                    sb.Append(Tabs(2) + "public readonly int[] Ancestors = new int[0];" + Environment.NewLine);
                }
                else
                {
                    sb.Append(Tabs(2) + "public readonly int[] Ancestors = {" + ancestorIds + "};" + Environment.NewLine);
                }

                string instanceIds = String.Join(",", GetInstanceIds(types, types[i]));
                if (String.IsNullOrEmpty(instanceIds))
                {
                    sb.Append(Tabs(2) + "public readonly int[] Instances = new int[0];" + Environment.NewLine);
                }
                else
                {
                    sb.Append(Tabs(2) + "public readonly int[] Instances = {" + instanceIds + "};" + Environment.NewLine);
                }

                string subTypeIds = String.Join(",", GetSubTypeIds(types, types[i]));
                if (String.IsNullOrEmpty(subTypeIds))
                {
                    sb.Append(Tabs(2) + "public readonly int[] SubTypes = new int[0];" + Environment.NewLine);
                }
                else
                {
                    sb.Append(Tabs(2) + "public readonly int[] SubTypes = {" + subTypeIds + "};" + Environment.NewLine);
                }

                string superTypeIds = String.Join(",", GetSuperTypeIds(types, types[i]));
                if (String.IsNullOrEmpty(superTypeIds))
                {
                    sb.Append(Tabs(2) + "public readonly int[] SuperTypes = new int[0];" + Environment.NewLine);
                }
                else
                {
                    sb.Append(Tabs(2) + "public readonly int[] SuperTypes = {" + superTypeIds + "};" + Environment.NewLine);
                }

                TypeDef microdataTypeDefinition = types[i];
                List<PropertyDef> currTypeProperties = SqlDb.GetTypeProperties(microdataTypeDefinition.TypeId);

                string propertyIds = String.Join(",", GetPropertyIds(currTypeProperties, types[i].Properties));
                if (String.IsNullOrEmpty(propertyIds))
                {
                    sb.Append(Tabs(2) + "public readonly int[] Properties = new int[0];" + Environment.NewLine);
                }
                else
                {
                    sb.Append(Tabs(2) + "public readonly int[] Properties = {" + propertyIds + "};" + Environment.NewLine + Environment.NewLine);
                }

                List<PropertyDef> ancestorTypeProperties = SqlDb.GetTypeAncestorPropertiesAll(microdataTypeDefinition.TypeId);
                List<PropertyDef> ancestorSpecific_Properties = SqlDb.GetTypeSpecific_Properties(microdataTypeDefinition.TypeId);
                //sb.Append(Tabs(2) + "/// <summary>" + Environment.NewLine);
                //sb.Append(Tabs(2) + "/// " + currTypeProperties[j].Comment + Environment.NewLine);
                //sb.Append(Tabs(2) + "/// </summary>" + Environment.NewLine);
                //properCaseId = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(currTypeProperties[j].Id);
                //sb.Append(Tabs(2) + "public readonly int[] " + properCaseId + ";" + Environment.NewLine + Environment.NewLine);

                GetProperties(sb, ancestorTypeProperties, currTypeProperties);
                GetProperties(sb, ancestorSpecific_Properties, currTypeProperties);

                sb.Append(Tabs(1) + "}" + Environment.NewLine);
                sb.Append("}");
                File.WriteAllText(@"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Schemas\Microdata\Types\" + types[i].Id + ".cs", sb.ToString());
            }
        }

        private static void GetProperties(StringBuilder sb, List<PropertyDef> searchForTypeProperties, List<PropertyDef> currTypeProperties)
        {
            List<PropertyDef> currTypePropertiesForDelete = new List<PropertyDef>();
            for (int j = 0; j < searchForTypeProperties.Count; j++)
            {
                for (int k = 0; k < currTypeProperties.Count; k++)
                {
                    if (currTypePropertiesForDelete.Count == currTypeProperties.Count)
                        break;
                    if (currTypeProperties[k].PropertyId == searchForTypeProperties[j].PropertyId)
                    {
                        if (!currTypePropertiesForDelete.Contains(searchForTypeProperties[j]))
                            currTypePropertiesForDelete.Add(searchForTypeProperties[j]);
                        break;
                    }
                }
                if (currTypePropertiesForDelete.Count == currTypeProperties.Count)
                    break;
            }
            for (int j = 0; j < currTypePropertiesForDelete.Count; j++)
            {
                currTypeProperties.Remove(currTypePropertiesForDelete[j]);
            }
            string properCaseId = String.Empty;
            for (int j = 0; j < currTypeProperties.Count; j++)
            {
                sb.Append(Tabs(2) + "/// <summary>" + Environment.NewLine);
                sb.Append(Tabs(2) + "/// " + currTypeProperties[j].Comment + Environment.NewLine);
                sb.Append(Tabs(2) + "/// </summary>" + Environment.NewLine);
                properCaseId = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(currTypeProperties[j].Id);
                sb.Append(Tabs(2) + properCaseId + sufix + " " + properCaseId + " { get; set; }" + Environment.NewLine + Environment.NewLine);
            }
        }

        private static int[] GetAncestorIds(List<TypeDef> types, TypeDef type)
        {
            string[] names = type.Ancestors;
            int[] ids = GetTypesIds(types, names);
            return ids;
        }

        private static int[] GetInstanceIds(List<TypeDef> types, TypeDef type)
        {
            string[] names = type.Instances;
            int[] ids = GetTypesIds(types, names);
            return ids;
        }

        private static int[] GetSubTypeIds(List<TypeDef> types, TypeDef type)
        {
            string[] names = type.SubTypes;
            int[] ids = GetTypesIds(types, names);
            return ids;
        }

        private static int[] GetSuperTypeIds(List<TypeDef> types, TypeDef type)
        {
            string[] names = type.SuperTypes;
            int[] ids = GetTypesIds(types, names);
            return ids;
        }

        private static int[] GetTypesIds(List<TypeDef> types, string[] names)
        {
            if (names == null)
                return new int[0];

            int[] ids = new int[names.Length];
            int n = 0;
            if (names != null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    for (int j = 0; j < types.Count; j++)
                    {
                        if (names[i] == types[j].Id)
                        {
                            ids[n] = types[j].TypeId - 1;
                            n++;
                            break;
                        }
                    }
                }
            }
            return ids;
        }

        private static int[] GetPropertyIds(List<PropertyDef> props, string[] names)
        {
            if (names == null)
                return new int[0];

            int[] ids = new int[names.Length];
            int n = 0;
            if (names != null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    for (int j = 0; j < props.Count; j++)
                    {
                        if (names[i] == props[j].Id)
                        {
                            ids[n] = props[j].PropertyId - 1;
                            n++;
                            break;
                        }
                    }
                }
            }
            return ids;
        }

        private static string Tabs(int x)
        {
            string tabs = String.Empty;
            for (int i = 0; i < x; i++)
            {
                tabs += '\t';
            }
            return tabs;
        }

        public static object GetPropertyResource(string name, Type type)
        {
            Assembly assembly = Assembly.GetAssembly(type);
            ResourceManager resman = new ResourceManager("Sasoma.Languages.Core.PropertyLabels", assembly);
            return resman.GetString(name);
        }

        public static object GetTypeResource(string name, Type type)
        {
            // Create the resource manager.
            Assembly assembly = Assembly.GetAssembly(type);

            //ResFile.Strings -> <Namespace>.<ResourceFileName i.e. Strings.resx>
            ResourceManager resman = new ResourceManager("Sasoma.Languages.Core.TypeLabels", assembly);

            // Load the value of string value for Client
            return resman.GetString(name);
        }
    }
}
