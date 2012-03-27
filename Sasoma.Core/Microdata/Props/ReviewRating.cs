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
	/// The rating given in this review. Note that reviews can themselves be rated. The <code>reviewRating</code> applies to rating given by the review. The <code>aggregateRating</code> property applies to the review itself, as a creative work.
	/// </summary>
	public class ReviewRating_Core : PropertyCore
	{
		public ReviewRating_Core()
		{
			this._PropertyId = 198;
			this._Id = "reviewRating";
			string label = "";
			GetLabel(out label, "ReviewRating", typeof(ReviewRating_Core));
			this._Label = label;
			this._Domains = new int[]{229};
			this._Ranges = new int[]{222};
		}
	}
}