using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sasoma.Microdata.Interfaces
{
    public interface IMicrodata
    {
        int[] Ancestors { get; }
        string Id { get; }
        string Label { get; }
        int[] Properties { get; }
        string Schema_Org_Url { get; }
        int[] SubTypes { get; }
        int[] SuperTypes { get; }
        int TypeId { get; }
    }

}
