using System;
using System.Collections.Generic;
using Sasoma.MicrodataBase;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
using System.Resources;
using System.Reflection;

namespace Tester.SasomaUtils
{
    internal class Processor
    {
        internal static void Act()
        {
            WriteClasses.Write();
            WriteProperties.Write();
        }
    }
}
