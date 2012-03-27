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
	/// The offer price of the product.
	/// </summary>
	public class Price_Core : PropertyCore
	{
		public Price_Core()
		{
			this._PropertyId = 165;
			this._Id = "price";
			string label = "";
			GetLabel(out label, "Price", typeof(Price_Core));
			this._Label = label;
			this._Domains = new int[]{189};
			this._Ranges = new int[]{5,6};
		}
	}
}