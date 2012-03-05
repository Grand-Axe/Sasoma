using System;
namespace Sasoma.MicrodataBase
{
    interface IMicrodata
    {
        string Comment { get; set; }
        string Comment_Plain { get; set; }
        string Id { get; set; }
        string Label { get; set; }
    }
}
