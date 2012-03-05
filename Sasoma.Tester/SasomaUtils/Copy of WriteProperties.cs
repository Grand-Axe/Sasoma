using System;
using System.Collections.Generic;
using Sasoma.MicrodataBase;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
using System.Resources;
using System.Reflection;
using Sasoma.Utils;

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
            for (int i = 0; i < 1; i++)
            //for (int i = 0; i < props.Count; i++)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("using System;" + Environment.NewLine);
                sb.Append("using System.Globalization;" + Environment.NewLine);
                sb.Append("using System.Collections.Generic;" + Environment.NewLine + Environment.NewLine);
                sb.Append("using Sasoma.Utils;" + Environment.NewLine);
                sb.Append("using Sasoma.MicrodataBase;" + Environment.NewLine);
                sb.Append("using Sasoma.Languages.Core;" + Environment.NewLine);
                sb.Append("using Sasoma.Microdata.Types;" + Environment.NewLine + Environment.NewLine);

                sb.Append("namespace Sasoma.Microdata.Properties" + Environment.NewLine);
                sb.Append("{" + Environment.NewLine);

                sb.Append(Tabs(1) + "/// <summary>" + Environment.NewLine);
                sb.Append(Tabs(1) + "/// " + props[i].Comment + Environment.NewLine);
                sb.Append(Tabs(1) + "/// </summary>" + Environment.NewLine);

                sb.Append(Tabs(1) + "public class " + TitleCase(props[i].Id) + sufix + " : Sasoma.Microdata.Core" + Environment.NewLine);                
                sb.Append(Tabs(1) + "{" + Environment.NewLine);

                sb.Append(Tabs(2) + "//consts are called in the same way as static variables.;" + Environment.NewLine);
                sb.Append(Tabs(2) + "public const int PropertyId = " + (props[i].PropertyId - 1).ToString() + ";" + Environment.NewLine);
                sb.Append(Tabs(2) + "public const string Id = \"" + props[i].Id + "\";" + Environment.NewLine);
                sb.Append(Tabs(2) + "public readonly string Label =  CultureManager.GetResourceString(\"" + props[i].Label + "\", typeof(" + TitleCase(props[i].Id) + sufix + "), Core.BaseName_Properties);" + Environment.NewLine);
                //sb.Append(Tabs(2) + "public const string Label = \"" + GetTypeResource(props[i].Label, props[i].GetType()) + "\";" + Environment.NewLine);

                string domainIds = String.Join(",", GetDomains(types, props[i]));
                if (String.IsNullOrEmpty(domainIds))
                {
                    sb.Append(Tabs(2) + "public readonly int[] Domains = new int[0];" + Environment.NewLine);
                }
                else
                {
                    sb.Append(Tabs(2) + "public readonly int[] Domains = {" + domainIds + "};" + Environment.NewLine);
                }

                string rangeIds = String.Join(",", GetRanges(types, props[i]));
                if (String.IsNullOrEmpty(rangeIds))
                {
                    sb.Append(Tabs(2) + "public readonly int[] Ranges = new int[0];" + Environment.NewLine);
                }
                else
                {
                    sb.Append(Tabs(2) + "public readonly int[] Ranges = {" + rangeIds + "};" + Environment.NewLine);
                }

                sb.Append(Tabs(1) + "}" + Environment.NewLine);
                sb.Append("}");
                File.WriteAllText(@"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Schemas\Microdata\Properties\" + TitleCase(props[i].Id) + ".cs", sb.ToString());
            }
        }

        private static string TitleCase(string item)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item);
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

        private static string PropertyString(StringBuilder sb, string name, string comment, string typeString, string value, bool isReadonly)
        {
            string propertyString = String.Empty;
            if (comment != null)
            {
                sb.Append(Tabs(2) + "/// <summary>" + Environment.NewLine);
                sb.Append(Tabs(2) + "/// " + comment + Environment.NewLine);
                sb.Append(Tabs(2) + "/// </summary>" + Environment.NewLine);
            }
            sb.Append(Tabs(2) + "public " + typeString + " " + name + Environment.NewLine);
            sb.Append(Tabs(2) + "{" + Environment.NewLine);
            sb.Append(Tabs(3) + "get" + Environment.NewLine);
            sb.Append(Tabs(3) + "{" + Environment.NewLine);
            sb.Append(Tabs(4) + "return" + value + ";" + Environment.NewLine);
            sb.Append(Tabs(3) + "}" + Environment.NewLine);
            sb.Append(Tabs(2) + "}" + Environment.NewLine);
            return propertyString;
        }
    }
}
