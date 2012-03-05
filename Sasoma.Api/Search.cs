using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using Sasoma.Microdata.Interfaces;
using Sasoma.Microdata.Properties;
using Sasoma.Api.FixedVars;

namespace Sasoma.API
{
    public class Search
    {
        private static string[] booleanValues = Enum.GetNames(typeof(TypeVars.BooleanValues));
        private static string[] bookFormatTypes = Enum.GetNames(typeof(TypeVars.BookFormatType));
        private static string[] itemAvailabilities = Enum.GetNames(typeof(TypeVars.ItemAvailability));
        private static string[] offerItemConditions = Enum.GetNames(typeof(TypeVars.OfferItemCondition));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string[] GetInstance(int index)
        {
            switch (index)
            {
                case 1:
                    return booleanValues;
                case 43:
                    return bookFormatTypes;
                case 141:
                    return itemAvailabilities;
                case 191:
                    return offerItemConditions;
                default:
                    return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int GetInstance(string name)
        {
            string nameToUpper = name.ToUpper();

            for (int i = 0; i < booleanValues.Length; i++)
            {
                if (booleanValues[i].ToUpper() == nameToUpper)
                    return 1;
            }

            for (int i = 0; i < bookFormatTypes.Length; i++)
            {
                if (bookFormatTypes[i].ToUpper() == nameToUpper)
                    return 43;
            }

            for (int i = 0; i < itemAvailabilities.Length; i++)
            {
                if (itemAvailabilities[i].ToUpper() == nameToUpper)
                    return 141;
            }

            for (int i = 0; i < offerItemConditions.Length; i++)
            {
                if (offerItemConditions[i].ToUpper() == nameToUpper)
                    return 191;
            }
            return -1;
        }
    }
}
