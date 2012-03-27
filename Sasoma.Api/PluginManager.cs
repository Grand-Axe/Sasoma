using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

using Sasoma.Microdata;
using Sasoma.Microdata.Interfaces;

/*  //Example usage
    PluginManager<IIdentified> pluginManager = new PluginManager<IIdentified>();
    Dictionary<string, Lazy<IIdentified>> plugins = pluginManager.PluginDictionary;
    if(plugins == null)
        pluginManager.Load();
    if (plugins != null)
    {
        IIdentified plugin = plugins["VerySimplePlugin"].Value;
        ICreativeWork plugin2 = (ICreativeWork)plugins["StoneSculpturePlugin"].Value;
    } 
*/

namespace Sasoma.Api
{
    public class PluginManager<T> where T : IIdentified
    {
        /// <summary>
        /// 
        /// </summary>
        [ImportMany]
        public IEnumerable<Lazy<T>> PluginCollection { get; set; }

        private static Dictionary<string, Lazy<T>> pluginDictionary;
        /// <summary>
        /// 
        /// </summary>
        public static Dictionary<string, Lazy<T>> PluginDictionary
        {
            get
            {
                if (pluginDictionary == null)
                {
                    PluginManager<T> plgManager = new PluginManager<T>();
                    return plgManager.Load();
                }
                return pluginDictionary;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, Lazy<T>> Load()
        {
            AggregateCatalog aggregateCatalog = new AggregateCatalog();
            string binPath = Directory.GetCurrentDirectory();
            int indexOfBin = binPath.IndexOf("\\bin", StringComparison.InvariantCultureIgnoreCase);
            string directoryPath = binPath.Substring(0, indexOfBin) + "\\Extensions";
            DirectoryCatalog directoryCatalog = new DirectoryCatalog(directoryPath, "*.dll");
            aggregateCatalog.Catalogs.Add(directoryCatalog);
            CompositionContainer container = new CompositionContainer(aggregateCatalog);
            container.ComposeParts(this);

            string key = String.Empty;
            if (pluginDictionary == null)
            {
                pluginDictionary = new Dictionary<string, Lazy<T>>();
                foreach (Lazy<T> plugin in PluginCollection)
                {
                    key = plugin.Value.Id;
                    if (!pluginDictionary.ContainsKey(key))
                        pluginDictionary.Add(key, plugin);
                }
            }

            return pluginDictionary;
        }
    }

}
