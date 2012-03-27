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
	/// The currency accepted (in <a href=\http://en.wikipedia.org/wiki/ISO_4217\ target=\new\>ISO 4217 currency format</a>).
	/// </summary>
	public class CurrenciesAccepted_Core : PropertyCore
	{
		public CurrenciesAccepted_Core()
		{
			this._PropertyId = 60;
			this._Id = "currenciesAccepted";
			string label = "";
			GetLabel(out label, "CurrenciesAccepted", typeof(CurrenciesAccepted_Core));
			this._Label = label;
			this._Domains = new int[]{155};
			this._Ranges = new int[]{6};
		}
	}
}