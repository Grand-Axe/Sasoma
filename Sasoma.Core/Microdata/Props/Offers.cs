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
	/// An offer to sell this item\u2014for example, an offer to sell a product, the DVD of a movie, or tickets to an event.
	/// </summary>
	public class Offers_Core : PropertyCore
	{
		public Offers_Core()
		{
			this._PropertyId = 151;
			this._Id = "offers";
			string label = "";
			GetLabel(out label, "Offers", typeof(Offers_Core));
			this._Label = label;
			this._Domains = new int[]{215,78,98};
			this._Ranges = new int[]{189};
		}
	}
}