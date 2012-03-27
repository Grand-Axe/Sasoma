using System;
using System.Collections.Generic;

using Sasoma.Microdata.Interfaces;

namespace Sasoma.Microdata
{
    public class PropertyCore : MicrodataCore, IProperty
    {
        protected int _PropertyId;
        public int PropertyId
        {
            get
            {
                return _PropertyId;
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

        protected string _Label;
        public string Label
        {
            get
            {
                return _Label;
            }
        }

        protected int[] _Domains;
        public int[] Domains
        {
            get
            {
                return _Domains;
            }
        }

        protected int[] _Ranges;
        public int[] Ranges
        {
            get
            {
                return _Ranges;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        internal const string BaseName = "Sasoma.Languages.Core.PropertyLabels";

        public class Data<T>
        {
            public T Value { get; set; }
        }
    }
}
