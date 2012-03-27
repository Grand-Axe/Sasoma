using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Microdata.Interfaces;

namespace Sasoma.Microdata
{
    /// <summary>
    /// 
    /// </summary>
    public class MicrodataCore : CacheManager, ILabel
    {
        private string labelCacheKey = "Label";
        /// <summary>
        /// 
        /// </summary>
        public string LabelCacheKey
        {
            get
            {
                return labelCacheKey;
            }
            set
            {
                labelCacheKey = value;
            }
        }

        private string baseNameAlternate = null;
        /// <summary>
        /// 
        /// </summary>
        public string BaseNameAlternate
        {
            get
            {
                return baseNameAlternate;
            }
            set
            {
                baseNameAlternate = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="label"></param>
        /// <param name="resourceString"></param>
        /// <param name="type"></param>
        public void GetLabel(out string label, string resourceString, Type type)
        {
            label = String.Empty;
            if (BaseNameAlternate == null)
            {
                if(type is IProperty)
                    GetLabel(out label, resourceString, type, PropertyCore.BaseName);
                else
                    GetLabel(out label, resourceString, type, TypeCore.BaseName);
            }
            else
                GetLabel(out label, resourceString, type, BaseNameAlternate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="label"></param>
        /// <param name="resourceString"></param>
        /// <param name="type"></param>
        public void GetLabel(out string label, string resourceString, Type type, string baseName)
        {
            string temp = null;
            if (LabelCacheKey == "Label")
            {
                object value = GetFromCache("Label");
                if (value == null)
                {
                    value = CultureManager.GetResourceString(resourceString, type, baseName);
                    SetCache(LabelCacheKey, value);
                    temp = (string)value;
                }
            }
            else
            {
                object value = GetFromCache(LabelCacheKey);
                if (value == null)
                {
                    value = CultureManager.GetResourceString(LabelCacheKey, type, CacheManager.BaseName_Custom);
                    SetCache(LabelCacheKey, value);
                    temp = (string)value;
                }
            }
            label = temp;
        }

    }
}
