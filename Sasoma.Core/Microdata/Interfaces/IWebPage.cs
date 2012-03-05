using System;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface IWebPage : ICreativeWork
    {
        Breadcrumb_Core Breadcrumb { get; set; }
        IsPartOf_Core IsPartOf { get; set; }
        MainContentOfPage_Core MainContentOfPage { get; set; }
        PrimaryImageOfPage_Core PrimaryImageOfPage { get; set; }
        SignificantLinks_Core SignificantLinks { get; set; }
    }
}
