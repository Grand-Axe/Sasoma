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
        static string[] commonIds = { "URL", "AGGREGATERATING", "DURATION" };

        internal static void Write()
        {
            List<TypeDef> types = SqlDb.GetTypeAll();
            for (int i = 0; i < types.Count; i++)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("using System;" + Environment.NewLine);
                sb.Append("using System.Globalization;" + Environment.NewLine);
                sb.Append("using System.Collections.Generic;" + Environment.NewLine + Environment.NewLine);
                sb.Append("using Sasoma.Utils;" + Environment.NewLine);
                sb.Append("using Sasoma.Microdata.Interfaces;" + Environment.NewLine);
                sb.Append("using Sasoma.Languages.Core;" + Environment.NewLine);
                sb.Append("using Sasoma.Microdata.Properties;" + Environment.NewLine + Environment.NewLine);

                sb.Append("namespace Sasoma.Microdata.Types" + Environment.NewLine);
                sb.Append("{" + Environment.NewLine);

                sb.Append(Tabs(1) + "/// <summary>" + Environment.NewLine);
                sb.Append(Tabs(1) + "/// " + types[i].Comment + Environment.NewLine);
                sb.Append(Tabs(1) + "/// </summary>" + Environment.NewLine);
                string[] ancestors = types[i].Ancestors;
                if (ancestors == null )
                {
                    sb.Append(Tabs(1) + "public class " + types[i].Id + sufix + " : Core, I" + types[i].Id + Environment.NewLine);
                }
                else
                {
                    sb.Append(Tabs(1) + "public class " + types[i].Id + sufix + " : TypeCore" + GetInterface(ancestors[ancestors.Length - 1]) + Environment.NewLine);
                }
                sb.Append(Tabs(1) + "{" + Environment.NewLine);

                PropertyString(sb, "TypeId", null, "int", (types[i].TypeId - 1).ToString(), types[i].Id);
                PropertyString(sb, "Id", null, "string", "\"" + types[i].Id + "\"", types[i].Id);
                PropertyString(sb, "Schema_Org_Url", null, "string", "\"" + types[i].Url + "\"", types[i].Id);
                PropertyString(sb, "Label", null, "string", "CultureManager.GetResourceString(\"" + types[i].Id + "\", typeof(" + types[i].Id + sufix + "), TypeCore.BaseName)", types[i].Id);

                string ancestorIds = String.Join(",", GetAncestorIds(types, types[i]));
                if (String.IsNullOrEmpty(ancestorIds))
                {
                    PropertyString(sb, "Ancestors", null, "int[]", "new int[0]", types[i].Id);
                }
                else
                {
                    PropertyString(sb, "Ancestors", null, "int[]", "new int[]{" + ancestorIds + "}", types[i].Id);
                }

                if (ancestors != null && ancestors.Length > 0)
                {
                    if (ancestors[0] == "DataType")
                    {
                        string instanceIds = String.Join(",", GetInstanceIds(types, types[i]));
                        if (String.IsNullOrEmpty(instanceIds))
                        {
                            PropertyString(sb, "Instances", null, "int[]", "new int[0]", types[i].Id);
                        }
                        else
                        {
                            PropertyString(sb, "Instances", null, "int[]", "new int[]{" + instanceIds + "}", types[i].Id);
                        }
                    }
                }

                string subTypeIds = String.Join(",", GetSubTypeIds(types, types[i]));
                if (String.IsNullOrEmpty(subTypeIds))
                {
                    PropertyString(sb, "SubTypes", null, "int[]", "new int[0]", types[i].Id);
                }
                else
                {
                    PropertyString(sb, "SubTypes", null, "int[]", "new int[]{" + subTypeIds + "}", types[i].Id);
                }

                string superTypeIds = String.Join(",", GetSuperTypeIds(types, types[i]));
                if (String.IsNullOrEmpty(superTypeIds))
                {
                    PropertyString(sb, "SuperTypes", null, "int[]", "new int[0]", types[i].Id);
                }
                else
                {
                    PropertyString(sb, "SuperTypes", null, "int[]", "new int[]{" + superTypeIds + "}", types[i].Id);
                }

                TypeDef microdataTypeDefinition = types[i];
                List<PropertyDef> currTypeProperties = SqlDb.GetTypeProperties(microdataTypeDefinition.TypeId);

                string propertyIds = String.Join(",", GetPropertyIds(currTypeProperties, types[i].Properties));
                if (String.IsNullOrEmpty(propertyIds))
                {
                    PropertyString(sb, "Properties", null, "int[]", "new int[0]", types[i].Id);
                }
                else
                {
                    PropertyString(sb, "Properties", null, "int[]", "new int[]{" + propertyIds + "}", types[i].Id);
                }
                sb.Append(Environment.NewLine);

                List<PropertyDef> ancestorTypeProperties = SqlDb.GetTypeAncestorPropertiesAll(microdataTypeDefinition.TypeId);
                List<PropertyDef> ancestorSpecific_Properties = SqlDb.GetTypeSpecific_Properties(microdataTypeDefinition.TypeId);

                //GetProperties(sb, ancestorTypeProperties, currTypeProperties);
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
                string currTypePropLabel = WriteProperties.GetPropertyName(currTypeProperties[j]);
                string currTypePropLabelType = currTypePropLabel;
                for (int k = 0; k < commonIds.Length; k++)
                {
                    if (currTypePropLabel.ToUpper() == commonIds[k])
                    {
                        currTypePropLabelType = "Properties." + currTypePropLabelType;
                        break;
                    }
                }
                sb.Append(Tabs(2) + "public " + currTypePropLabelType + sufix + " " + currTypePropLabel + " { get; set; }" + Environment.NewLine + Environment.NewLine);
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

        private static void PropertyString(StringBuilder sb, string name, string comment, string typeString, string valueToFile, string type)
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
                sb.Append(Tabs(4) + "GetLabel(out label, \"" + TitleCase(type) + "\", typeof(" + TitleCase(type) + sufix + "));" + Environment.NewLine);
                sb.Append(Tabs(4) + "return label;" + Environment.NewLine);
            }
            else
            {
                sb.Append(Tabs(4) + "return " + valueToFile + ";" + Environment.NewLine);
            }
            sb.Append(Tabs(3) + "}" + Environment.NewLine);
            sb.Append(Tabs(2) + "}" + Environment.NewLine + Environment.NewLine);
        }

        private static string TitleCase(string item)
        {
            string start = Char.ToUpper(item[0]).ToString();
            string end = item.Substring(1);
            return start + end;
            //return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item);
        }

        private static string GetInterface(string name)
        {
            string[] interfaces = {
                                    "DataType",
                                    "Thing",
                                    "AdministrativeArea",
                                    "Article",
                                    "AutomotiveBusiness",
                                    "BodyOfWater",
                                    "CivicStructure",
                                    "CollectionPage",
                                    "ContactPoint",
                                    "CreativeWork",
                                    "EducationalOrganization",
                                    "EntertainmentBusiness",
                                    "Enumeration",
                                    "Event",
                                    "FinancialService",
                                    "FoodEstablishment",
                                    "GovernmentBuilding",
                                    "GovernmentOffice",
                                    "HealthAndBeautyBusiness",
                                    "HomeAndConstructionBusiness",
                                    "Intangible",
                                    "Landform",
                                    "LocalBusiness",
                                    "LodgingBusiness",
                                    "MediaObject",
                                    "MedicalOrganization",
                                    "MusicPlaylist",
                                    "Number",
                                    "Offer",
                                    "Organization",
                                    "PerformingGroup",
                                    "Place",
                                    "PlaceOfWorship",
                                    "ProfessionalService",
                                    "Quantity",
                                    "Rating",
                                    "Residence",
                                    "SportsActivityLocation",
                                    "Store",
                                    "StructuredValue",
                                    "Text",
                                    "UserInteraction",
                                    "WebPage",
                                    "WebPageElement"};
            for (int i = 0; i < interfaces.Length; i++)
            {
                if (interfaces[i] == name)
                {
                    return ", I" + interfaces[i];
                }
            }
            return String.Empty;
        }

    }
}
