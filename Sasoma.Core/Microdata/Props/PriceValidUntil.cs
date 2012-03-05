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
	/// The date after which the price is no longer available.
	/// </summary>
	public class PriceValidUntil_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 168;
			}
		}

		public string Id
		{
			get
			{
				return "priceValidUntil";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PriceValidUntil", typeof(PriceValidUntil_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{189};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{2};
			}
		}

	}
}