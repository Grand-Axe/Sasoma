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
	/// Data type: Number.
	/// </summary>
	public class Number_Core : TypeCore, IDataType
	{
		public int TypeId
		{
			get
			{
				return 5;
			}
		}

		public string Id
		{
			get
			{
				return "Number";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/Number";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Number", typeof(Number_Core));
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
				return new int[0];
			}
		}

		public int[] SubTypes
		{
			get
			{
				return new int[]{3,4};
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