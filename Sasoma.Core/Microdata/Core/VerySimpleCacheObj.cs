using System;
using System.Linq;
using System.Text;
using System.Web;
using System.Collections.Generic;

using Sasoma.Microdata.Interfaces;

namespace Sasoma.Microdata
{
    /// <summary>
    /// A very simple class to manage web very simple caching.
    /// </summary>
    public class VerySimpleCacheObj : ICache
    {
        /// <summary>
        /// Gets a key/value object with the key from the cache.
        /// </summary>
        /// <param name="key">Key of the cache object.</param>
        /// <returns>object.</returns>
        public object GetFromCache(string key)
        {
            object o = HttpContext.Current.Cache[key];
            return o;
        }

        /// <summary>
        /// Adds a new object to the cache.
        /// </summary>
        /// <param name="key">Key of the new key/value cache object.</param>
        /// <param name="value">Value of the new key/value cache object.</param>
        public void SetCache(string key, object value)
        {
            HttpContext.Current.Cache[key] = value;
        }
    }
}
