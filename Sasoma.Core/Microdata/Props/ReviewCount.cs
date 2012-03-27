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
	/// The count of total number of reviews.
	/// </summary>
	public class ReviewCount_Core : PropertyCore
	{
		public ReviewCount_Core()
		{
			this._PropertyId = 195;
			this._Id = "reviewCount";
			string label = "";
			GetLabel(out label, "ReviewCount", typeof(ReviewCount_Core));
			this._Label = label;
			this._Domains = new int[]{13};
			this._Ranges = new int[]{5};
		}
	}
}