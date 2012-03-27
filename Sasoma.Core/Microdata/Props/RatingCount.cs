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
	/// The count of total number of ratings.
	/// </summary>
	public class RatingCount_Core : PropertyCore
	{
		public RatingCount_Core()
		{
			this._PropertyId = 182;
			this._Id = "ratingCount";
			string label = "";
			GetLabel(out label, "RatingCount", typeof(RatingCount_Core));
			this._Label = label;
			this._Domains = new int[]{13};
			this._Ranges = new int[]{5};
		}
	}
}