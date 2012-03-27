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
	/// The date after which the price is no longer available.
	/// </summary>
	public class PriceValidUntil_Core : PropertyCore
	{
		public PriceValidUntil_Core()
		{
			this._PropertyId = 168;
			this._Id = "priceValidUntil";
			string label = "";
			GetLabel(out label, "PriceValidUntil", typeof(PriceValidUntil_Core));
			this._Label = label;
			this._Domains = new int[]{189};
			this._Ranges = new int[]{2};
		}
	}
}