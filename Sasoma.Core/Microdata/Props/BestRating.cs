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
	/// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
	/// </summary>
	public class BestRating_Core : PropertyCore
	{
		public BestRating_Core()
		{
			this._PropertyId = 29;
			this._Id = "bestRating";
			string label = "";
			GetLabel(out label, "BestRating", typeof(BestRating_Core));
			this._Label = label;
			this._Domains = new int[]{222};
			this._Ranges = new int[]{5,6};
		}
	}
}