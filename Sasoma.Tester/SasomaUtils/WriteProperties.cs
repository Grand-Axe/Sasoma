using System;
using System.Collections.Generic;
using Sasoma.MicrodataBase;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
using System.Resources;
using System.Reflection;
//using Sasoma.Utils;

namespace Tester.SasomaUtils
{
    internal class WriteProperties
    {
        internal static string sufix = "_Core";
        static string parent = String.Empty;

        internal static void Write()
        {
            List<TypeDef> types = SqlDb.GetTypeAll();
            List<PropertyDef> props = SqlDb.GetPropertiesAll();
            //for (int i = 0; i < 1; i++)
            for (int i = 0; i < props.Count; i++)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("using System;" + Environment.NewLine);
                sb.Append("using System.Globalization;" + Environment.NewLine);
                sb.Append("using System.Collections.Generic;" + Environment.NewLine + Environment.NewLine);
                sb.Append("using Sasoma.Utils;" + Environment.NewLine);
                sb.Append("using Sasoma.Microdata.Interfaces;" + Environment.NewLine);
                sb.Append("using Sasoma.Languages.Core;" + Environment.NewLine);
                sb.Append("using Sasoma.Microdata.Types;" + Environment.NewLine + Environment.NewLine);

                sb.Append("namespace Sasoma.Microdata.Properties" + Environment.NewLine);
                sb.Append("{" + Environment.NewLine);

                sb.Append(Tabs(1) + "/// <summary>" + Environment.NewLine);
                sb.Append(Tabs(1) + "/// " + props[i].Comment + Environment.NewLine);
                sb.Append(Tabs(1) + "/// </summary>" + Environment.NewLine);

                sb.Append(Tabs(1) + "public class " + GetPropertyName(props[i]) + sufix + " : PropertyCore, IProperty" + Environment.NewLine);                
                sb.Append(Tabs(1) + "{" + Environment.NewLine);

                PropertyString(sb, "PropertyId", null, "int", (props[i].PropertyId - 1).ToString(), props[i]);
                PropertyString(sb, "Id", null, "string", "\"" + props[i].Id + "\"", props[i]);
                PropertyString(sb, "Label", null, "string", "CultureManager.GetResourceString(\"" + props[i].Id + "\", typeof(" + GetPropertyName(props[i]) + sufix + "), PropertyCore.BaseName)", props[i]);
                
                string domainIds = String.Join(",", GetDomains(types, props[i]));
                if (String.IsNullOrEmpty(domainIds))
                {
                    PropertyString(sb, "Domains", null, "int[]", "new int[0]", props[i]);
                }
                else
                {
                    PropertyString(sb, "Domains", null, "int[]", "new int[]{" + domainIds + "}", props[i]);
                }

                string rangeIds = String.Join(",", GetRanges(types, props[i]));
                if (String.IsNullOrEmpty(rangeIds))
                {
                    PropertyString(sb, "Ranges", null, "int[]", "new int[0]", props[i]);
                }
                else
                {
                    PropertyString(sb, "Ranges", null, "int[]", "new int[]{" + rangeIds + "}", props[i]);
                }

                sb.Append(Tabs(1) + "}" + Environment.NewLine);
                sb.Append("}");
                File.WriteAllText(@"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Schemas\Microdata\Props\" + TitleCase(props[i].Id) + ".cs", sb.ToString());
            }
        }

        private static string TitleCase(string item)
        {
            string start = Char.ToUpper(item[0]).ToString();
            string end = item.Substring(1);
            return start + end;
            //return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item);
        }

        private static int[] GetDomains(List<TypeDef> types, PropertyDef prop)
        {
            string[] names = prop.Domains;
            int[] ids = GetPropertyIds(types, names);
            return ids;
        }

        private static int[] GetRanges(List<TypeDef> types, PropertyDef prop)
        {
            string[] names = prop.Ranges;
            int[] ids = GetPropertyIds(types, names);
            return ids;
        }


        private static int[] GetPropertyIds(List<TypeDef> types, string[] names)
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
            ResourceManager resman = new ResourceManager("Sasoma.Languages.Core.PropertyLabels", assembly);

            // Load the value of string value for Client
            return resman.GetString(name);
        }

        private static void PropertyString(StringBuilder sb, string name, string comment, string typeString, string valueToFile, PropertyDef prop)
        {
            string propertyString = String.Empty;
            if (comment != null)
            {
                sb.Append(Tabs(2) + "/// <summary>" + Environment.NewLine);
                sb.Append(Tabs(2) + "/// " + comment + Environment.NewLine);
                sb.Append(Tabs(2) + "/// </summary>" + Environment.NewLine);
            }
            string nameSmall = Char.ToLower(name[0]).ToString() + name.Substring(1);
            if (name == "Label")
            {
                sb.Append(Tabs(2) + "private " + typeString + " " + nameSmall + ";" + Environment.NewLine);
            }
            sb.Append(Tabs(2) + "public " + typeString + " " + name + Environment.NewLine);
            sb.Append(Tabs(2) + "{" + Environment.NewLine);
            sb.Append(Tabs(3) + "get" + Environment.NewLine);
            sb.Append(Tabs(3) + "{" + Environment.NewLine);
            if (name == "Label")
            {
                sb.Append(Tabs(4) + "GetLabel(out label, \"" + GetPropertyName(prop) + "\", typeof(" + GetPropertyName(prop) + sufix + "));" + Environment.NewLine);
                sb.Append(Tabs(4) + "return label;" + Environment.NewLine);
            }
            else
            {
                sb.Append(Tabs(4) + "return " + valueToFile + ";" + Environment.NewLine);
            }
            sb.Append(Tabs(3) + "}" + Environment.NewLine);
            sb.Append(Tabs(2) + "}" + Environment.NewLine + Environment.NewLine);
        }

        internal static string GetPropertyName(PropertyDef currProp)
        {
            string currPropLabel = String.Empty;
            string tempNameToUpper = String.Empty;
            string[] arrPropLabel = currProp.Label.Split(' ');
            string[] arrUpperCase = { "ISBN", "URL", "ID" };
            for (int k = 0; k < arrPropLabel.Length; k++)
            {
                bool isAllCapitalized = false;
                tempNameToUpper = arrPropLabel[k].ToUpper();

                for (int m = 0; m < arrUpperCase.Length; m++)
                {
                    if (tempNameToUpper == arrUpperCase[m])
                    {
                        arrPropLabel[k] = tempNameToUpper;
                        isAllCapitalized = true;
                        break;
                    }
                }

                if (!isAllCapitalized)
                    arrPropLabel[k] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(arrPropLabel[k]);

                currPropLabel += arrPropLabel[k];
            }
            return currPropLabel;
        }

    }
}
