using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Interfaces;

namespace Sasoma.Microdata.Properties
{
	/// <summary>
	/// The lowest price of all offers available.
	/// </summary>
	public class LowPrice_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 132;
			}
		}

		public string Id
		{
			get
			{
				return "lowPrice";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "LowPrice", typeof(LowPrice_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{12};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{5,6};
			}
		}

	}
}