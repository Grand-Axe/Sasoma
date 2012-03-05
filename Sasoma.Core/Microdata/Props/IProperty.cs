using System;
namespace Sasoma.Microdata.Props
{
    interface IProperty
    {
        int[] Domains { get; }
        string Id { get; }
        string Label { get; }
        int PropertyId { get; }
        int[] Ranges { get; }
    }
}
