using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sasoma.MicrodataBase
{
    public class PropertyDef : IMicrodata
    {
        public int PropertyId { get; set; }
        public string Comment { get; set; }
        public string Comment_Plain { get; set; }
        public string[] Domains { get; set; }
        public string Id { get; set; }
        public string Label { get; set; }
        public string[] Ranges { get; set; }
    }
}