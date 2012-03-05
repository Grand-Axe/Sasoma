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
	/// Boolean: True or False.
	/// </summary>
	public class Boolean_Core : TypeCore, IDataType
	{
		public int TypeId
		{
			get
			{
				return 0;
			}
		}

		public string Id
		{
			get
			{
				return "Boolean";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/Boolean";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Boolean", typeof(Boolean_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{1};
			}
		}

		public int[] Instances
		{
			get
			{
				return new int[]{0,0};
			}
		}

		public int[] SubTypes
		{
			get
			{
				return new int[0];
			}
		}

		public int[] SuperTypes
		{
			get
			{
				return new int[]{1};
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