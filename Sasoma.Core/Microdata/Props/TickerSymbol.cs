using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Interfaces;

namespace Sasoma.Microdata.Properties
{
	/// <summary>
	/// The exchange traded instrument associated with a Corporation object. The tickerSymbol is expressed as an exchange and an instrument name separated by a space character. For the exchange component of the tickerSymbol attribute, we reccommend using the controlled vocaulary of Market Identifier Codes (MIC) specified in ISO15022.
	/// </summary>
	public class TickerSymbol_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 220;
			}
		}

		public string Id
		{
			get
			{
				return "tickerSymbol";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "TickerSymbol", typeof(TickerSymbol_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{73};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{6};
			}
		}

	}
}