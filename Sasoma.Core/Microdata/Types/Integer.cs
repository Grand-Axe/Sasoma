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
	/// Data type: Integer.
	/// </summary>
	public class Integer_Core : TypeCore, INumber
	{
		public int TypeId
		{
			get
			{
				return 4;
			}
		}

		public string Id
		{
			get
			{
				return "Integer";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/Integer";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Integer", typeof(Integer_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{1,5};
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
				return new int[0];
			}
		}

		public int[] SuperTypes
		{
			get
			{
				return new int[]{5};
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