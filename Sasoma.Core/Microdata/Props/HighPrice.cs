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
	/// The highest price of all offers available.
	/// </summary>
	public class HighPrice_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 102;
			}
		}

		public string Id
		{
			get
			{
				return "highPrice";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "HighPrice", typeof(HighPrice_Core));
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