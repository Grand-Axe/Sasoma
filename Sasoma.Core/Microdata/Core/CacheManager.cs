using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Microdata.Interfaces;

namespace Sasoma.Microdata
{
    public class CacheManager : ICache
    {
        private ICache cache = new VerySimpleCacheObj();

        public string Id
        {
            get
            {
                return "CacheManager";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        internal const string BaseName_Custom = "Sasoma.Languages.Core.Custom";

        /// <summary>
        /// 
        /// </summary>
        public ICache Cache
        {
            get
            {
                return cache;
            }
            set
            {
                cache = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public object GetFromCache(string name)
        {
            return Cache.GetFromCache(name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void SetCache(string name, object value)
        {
            Cache.SetCache(name, value);
        }

    }
}
