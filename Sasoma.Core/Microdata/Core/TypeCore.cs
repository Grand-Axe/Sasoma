using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sasoma.Microdata
{
    /// <summary>
    /// 
    /// </summary>
    public class TypeCore : MicrodataCore
    {
        protected int _TypeId;
        public int TypeId
        {
            get
            {
                return _TypeId;
            }
        }

        protected string _Id;
        public new string Id
        {
            get
            {
                return _Id;
            }
        }

        protected string _Schema_Org_Url;
        public string Schema_Org_Url
        {
            get
            {
                return _Schema_Org_Url;
            }
        }

        protected string _Label;
        public string Label
        {
            get
            {
                return _Label;
            }
        }

        protected int[] _Ancestors;
        public int[] Ancestors
        {
            get
            {
                return _Ancestors;
            }
        }

        protected int[] _SubTypes;
        public int[] SubTypes
        {
            get
            {
                return _SubTypes;
            }
        }

        protected int[] _SuperTypes;
        public int[] SuperTypes
        {
            get
            {
                return _SuperTypes;
            }
        }

        protected int[] _Properties;
        public int[] Properties
        {
            get
            {
                return _Properties;
            }
        }

        protected int[] _Instances;
        public int[] Instances
        {
            get
            {
                return _Instances;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        internal const string BaseName = "Sasoma.Languages.Core.TypeLabels";
    }
}
