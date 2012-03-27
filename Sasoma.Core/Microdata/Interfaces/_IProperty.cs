using System;

namespace Sasoma.Microdata.Interfaces
{
    public interface IProperty: IMicrodata
    {
        int[] Domains { get; }
        int PropertyId { get; }
        int[] Ranges { get; }
    }
}
