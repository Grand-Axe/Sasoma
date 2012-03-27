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
	/// The highest price of all offers available.
	/// </summary>
	public class HighPrice_Core : PropertyCore
	{
		public HighPrice_Core()
		{
			this._PropertyId = 102;
			this._Id = "highPrice";
			string label = "";
			GetLabel(out label, "HighPrice", typeof(HighPrice_Core));
			this._Label = label;
			this._Domains = new int[]{12};
			this._Ranges = new int[]{5,6};
		}
	}
}