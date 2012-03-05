using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Interfaces;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Types
{
	/// <summary>
	/// The basic data types such as Integers, Strings, etc.
	/// </summary>
    public class DataType_Core : MicrodataCore, IDataType
	{
		public int TypeId
		{
			get
			{
				return 1;
			}
		}

		public string Id
		{
			get
			{
				return "DataType";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/DataType";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "DataType", typeof(DataType_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[0];
			}
		}

		public int[] SubTypes
		{
			get
			{
				return new int[]{0,2,5,6};
			}
		}

		public int[] SuperTypes
		{
			get
			{
				return new int[0];
			}
		}

		public int[] Properties
		{
			get
			{
				return new int[0];
			}
		}


	}
}