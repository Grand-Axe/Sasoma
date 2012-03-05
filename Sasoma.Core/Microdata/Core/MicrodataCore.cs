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
    public class MicrodataCore : Core
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="label"></param>
        /// <param name="resourceString"></param>
        /// <param name="type"></param>
        internal void GetLabel(out string label, string resourceString, Type type)
        {
            string temp = null;
            if (LabelCacheKey == "Label")
            {
                object value = GetFromCache("Label");
                if (value == null)
                {
                    value = CultureManager.GetResourceString(resourceString, type, TypeCore.BaseName);
                    SetCache(LabelCacheKey, value);
                    temp = (string)value;
                }
            }
            else
            {
                object value = GetFromCache(LabelCacheKey);
                if (value == null)
                {
                    value = CultureManager.GetResourceString(LabelCacheKey, type, Core.BaseName_Custom);
                    SetCache(LabelCacheKey, value);
                    temp = (string)value;
                }
            }
            label = temp;
        }

    }
}
