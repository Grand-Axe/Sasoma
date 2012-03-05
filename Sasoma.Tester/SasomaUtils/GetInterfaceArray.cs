using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Tester.SasomaUtils
{
    public class GetInterfaceArray
    {
        static List<string> ancestors = new List<string>{"DataType",
        "DataType,Number",
        "DataType,Text",
        "Thing",
        "Thing,CreativeWork",
        "Thing,CreativeWork,Article",
        "Thing,CreativeWork,MediaObject",
        "Thing,CreativeWork,MusicPlaylist",
        "Thing,CreativeWork,WebPage",
        "Thing,CreativeWork,WebPage,CollectionPage",
        "Thing,CreativeWork,WebPageElement",
        "Thing,Event",
        "Thing,Event,UserInteraction",
        "Thing,Intangible",
        "Thing,Intangible,Enumeration",
        "Thing,Intangible,Offer",
        "Thing,Intangible,Quantity",
        "Thing,Intangible,Rating",
        "Thing,Intangible,StructuredValue",
        "Thing,Intangible,StructuredValue,ContactPoint",
        "Thing,Organization",
        "Thing,Organization,EducationalOrganization",
        "Thing,Organization,LocalBusiness",
        "Thing,Organization,LocalBusiness,AutomotiveBusiness",
        "Thing,Organization,LocalBusiness,EntertainmentBusiness",
        "Thing,Organization,LocalBusiness,FinancialService",
        "Thing,Organization,LocalBusiness,FoodEstablishment",
        "Thing,Organization,LocalBusiness,GovernmentOffice",
        "Thing,Organization,LocalBusiness,HealthAndBeautyBusiness",
        "Thing,Organization,LocalBusiness,HomeAndConstructionBusiness",
        "Thing,Organization,LocalBusiness,LodgingBusiness",
        "Thing,Organization,LocalBusiness,MedicalOrganization",
        "Thing,Organization,LocalBusiness,ProfessionalService",
        "Thing,Organization,LocalBusiness,SportsActivityLocation",
        "Thing,Organization,LocalBusiness,Store",
        "Thing,Organization,PerformingGroup",
        "Thing,Place",
        "Thing,Place,AdministrativeArea",
        "Thing,Place,CivicStructure",
        "Thing,Place,CivicStructure,GovernmentBuilding",
        "Thing,Place,CivicStructure,PlaceOfWorship",
        "Thing,Place,Landform",
        "Thing,Place,Landform,BodyOfWater",
        "Thing,Place,Residence"};

        public static void GetArray()
        {
            List<string> toDelete = new List<string>();
            List<string> lastBorn = new List<string>();
            List<string> lastBornCopy = new List<string>();
            for (int i = 0; i < ancestors.Count; i++)
            {
                if (ancestors[i].Contains(","))
                {
                    string[] arr = ancestors[i].Split(',');
                    lastBorn.Add(arr[arr.Length - 1]);
                    lastBornCopy.Add(arr[arr.Length - 1]);
                }
                else
                {
                    lastBorn.Add(ancestors[i]);
                    lastBornCopy.Add(ancestors[i]);
                }
            }
            lastBorn.Sort();
            lastBornCopy.Sort();
            for (int i = 0; i < lastBorn.Count; i++)
            {
                for (int j = 0; j < lastBorn.Count; j++)
                {
                    
                }
            }
            File.WriteAllLines(@"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\dump.txt", lastBorn.ToArray());
        }
    }
}
