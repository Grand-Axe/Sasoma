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
	/// The lowest price of all offers available.
	/// </summary>
	public class LowPrice_Core : PropertyCore
	{
		public LowPrice_Core()
		{
			this._PropertyId = 132;
			this._Id = "lowPrice";
			string label = "";
			GetLabel(out label, "LowPrice", typeof(LowPrice_Core));
			this._Label = label;
			this._Domains = new int[]{12};
			this._Ranges = new int[]{5,6};
		}
	}
}