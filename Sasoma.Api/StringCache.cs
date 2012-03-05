using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Generic;

namespace Sasoma.Api
{
    /// <summary>
    /// A threadsafe dictionary to cache application strings.
    /// </summary>
    public static class StringCache
    {
        static IDictionary<int, string> cache;

        static StringCache()
        {
            cache = new Dictionary<int, string>();
        }

        public static string GetValue(int key)
        {
            string value;
            cache.TryGetValue(key, out value);
            return value;
        }

        public static void Add(int key, string data)
        {
            cache.Add(key, data);
        }

        public static bool Delete(int key)
        {
            return cache.Remove(key);
        }
    }

}
