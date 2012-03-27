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
	/// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
	/// </summary>
	public class WorstRating_Core : PropertyCore
	{
		public WorstRating_Core()
		{
			this._PropertyId = 239;
			this._Id = "worstRating";
			string label = "";
			GetLabel(out label, "WorstRating", typeof(WorstRating_Core));
			this._Label = label;
			this._Domains = new int[]{222};
			this._Ranges = new int[]{5,6};
		}
	}
}