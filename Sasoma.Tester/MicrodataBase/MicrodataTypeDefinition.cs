using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sasoma.MicrodataBase
{
    public class TypeDef : IMicrodata
    {
        public int TypeId { get; set; }
	    public string[] Ancestors {get;set;}
	    public string Comment {get;set;}
	    public string Comment_Plain {get;set;}
	    public string Id {get;set;}
	    public string[] Instances {get;set;}
	    public string Label {get;set;}
	    public string[] Properties {get;set;}
	    public string[] Specific_Properties {get;set;}
	    public string[] SubTypes {get;set;}
	    public string[] SuperTypes {get;set;}
	    public string Url {get;set;}
	    public bool IsDataType {get;set;}
    }
}
