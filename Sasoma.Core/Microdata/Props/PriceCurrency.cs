using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Microdata.Interfaces;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Types;

namespace Sasoma.Microdata.Properties
{
	/// <summary>
	/// The currency (in 3-letter <a href=\http://en.wikipedia.org/wiki/ISO_4217\>ISO 4217 format</a>) of the offer price.
	/// </summary>
	public class PriceCurrency_Core : PropertyCore
	{
		public PriceCurrency_Core()
		{
			this._PropertyId = 166;
			this._Id = "priceCurrency";
			string label = "";
			GetLabel(out label, "PriceCurrency", typeof(PriceCurrency_Core));
			this._Label = label;
			this._Domains = new int[]{189};
			this._Ranges = new int[]{6};
		}
	}
}