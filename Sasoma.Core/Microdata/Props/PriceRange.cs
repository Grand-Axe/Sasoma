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
	/// The price range of the business, for example <code>$$$</code>.
	/// </summary>
	public class PriceRange_Core : PropertyCore
	{
		public PriceRange_Core()
		{
			this._PropertyId = 167;
			this._Id = "priceRange";
			string label = "";
			GetLabel(out label, "PriceRange", typeof(PriceRange_Core));
			this._Label = label;
			this._Domains = new int[]{155};
			this._Ranges = new int[]{6};
		}
	}
}