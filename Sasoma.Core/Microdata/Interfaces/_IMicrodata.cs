using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Sasoma.Microdata.Interfaces
{
    [InheritedExport(typeof(IMicrodata))]
    public interface IMicrodata : IIdentified
    {
        string Label { get; }
    }
}
