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
	/// The exchange traded instrument associated with a Corporation object. The tickerSymbol is expressed as an exchange and an instrument name separated by a space character. For the exchange component of the tickerSymbol attribute, we reccommend using the controlled vocaulary of Market Identifier Codes (MIC) specified in ISO15022.
	/// </summary>
	public class TickerSymbol_Core : PropertyCore
	{
		public TickerSymbol_Core()
		{
			this._PropertyId = 220;
			this._Id = "tickerSymbol";
			string label = "";
			GetLabel(out label, "TickerSymbol", typeof(TickerSymbol_Core));
			this._Label = label;
			this._Domains = new int[]{73};
			this._Ranges = new int[]{6};
		}
	}
}