using System;
namespace Sasoma.Microdata.Interfaces
{
    interface ILabel
    {
        string BaseNameAlternate { get; set; }
        void GetLabel(out string label, string resourceString, Type type);
        void GetLabel(out string label, string resourceString, Type type, string baseName);
        string LabelCacheKey { get; set; }
    }
}
