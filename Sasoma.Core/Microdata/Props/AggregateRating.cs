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
	/// The overall rating, based on a collection of reviews or ratings, of the item.
	/// </summary>
	public class AggregateRating_Core : PropertyCore
	{
		public AggregateRating_Core()
		{
			this._PropertyId = 10;
			this._Id = "aggregateRating";
			string label = "";
			GetLabel(out label, "AggregateRating", typeof(AggregateRating_Core));
			this._Label = label;
			this._Domains = new int[]{193,215,78,206,189};
			this._Ranges = new int[]{13};
		}
	}
}