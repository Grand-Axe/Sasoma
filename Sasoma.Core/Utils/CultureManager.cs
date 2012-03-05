using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Sasoma.Utils
{
    /// <summary>
    /// This class manages resources and cultures for localisation and globalisation. 
    /// </summary>
    public class CultureManager
    {
        /// <summary>
        /// Initializes a new instance of the System.Resources.ResourceManager class. Returns the value of the specified System.String resource.
        /// </summary>
        /// <param name="name">The name of the resource to get.</param>
        /// <param name="type">A System.Type from which the System.Resources.ResourceManager derives all information for finding .resources files.</param>
        /// <param name="baseName">The root name of the resources. For example, the root name for the resource file named "MyResource.en-US.resources" is "MyResource".</param>
        /// <returns>string.</returns>
        public static string GetResourceString(string name, Type type, string baseName)
        {
            // Create the resource manager.
            Assembly assembly = Assembly.GetAssembly(type);

            //ResFile.Strings -> <Namespace>.<ResourceFileName i.e. Strings.resx>
            ResourceManager resman = new ResourceManager(baseName, assembly);

            // Load the value of string value for Client
            return resman.GetString(name);
        }

    }
}
