using System;

namespace Sasoma.Microdata.Interfaces
{
    public interface IProperty
    {
        int[] Domains { get; }
        string Id { get; }
        string Label { get; }
        int PropertyId { get; }
        int[] Ranges { get; }
    }
}
