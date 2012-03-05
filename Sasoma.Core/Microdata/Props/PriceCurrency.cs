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
	/// The currency (in 3-letter <a href=\http://en.wikipedia.org/wiki/ISO_4217\>ISO 4217 format</a>) of the offer price.
	/// </summary>
	public class PriceCurrency_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 166;
			}
		}

		public string Id
		{
			get
			{
				return "priceCurrency";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PriceCurrency", typeof(PriceCurrency_Core));
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
				return new int[]{6};
			}
		}

	}
}