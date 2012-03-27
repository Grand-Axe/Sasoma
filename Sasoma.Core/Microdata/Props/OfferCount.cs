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
	/// The number of offers for the product.
	/// </summary>
	public class OfferCount_Core : PropertyCore
	{
		public OfferCount_Core()
		{
			this._PropertyId = 150;
			this._Id = "offerCount";
			string label = "";
			GetLabel(out label, "OfferCount", typeof(OfferCount_Core));
			this._Label = label;
			this._Domains = new int[]{12};
			this._Ranges = new int[]{4};
		}
	}
}