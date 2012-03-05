using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Microdata.Interfaces;

namespace Sasoma.Microdata
{
    public class Core
    {
        private ICache cacheManager = new VerySimpleCacheObj();

        /// <summary>
        /// 
        /// </summary>
        internal const string BaseName_Custom = "Sasoma.Languages.Core.Custom";

        /// <summary>
        /// 
        /// </summary>
        public ICache CacheManager 
        {
            get
            {
                return cacheManager;
            }
            set
            {
                cacheManager = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public object GetFromCache(string name)
        {
            return CacheManager.GetFromCache(name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void SetCache(string name, object value)
        {
            CacheManager.SetCache(name, value);
        }

    }
}
