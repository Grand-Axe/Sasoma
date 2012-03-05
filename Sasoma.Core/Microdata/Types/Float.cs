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
	/// Data type: Floating number.
	/// </summary>
	public class Float_Core : TypeCore, INumber
	{
		public int TypeId
		{
			get
			{
				return 3;
			}
		}

		public string Id
		{
			get
			{
				return "Float";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/Float";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Float", typeof(Float_Core));
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