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
	/// The rating for the content.
	/// </summary>
	public class RatingValue_Core : PropertyCore
	{
		public RatingValue_Core()
		{
			this._PropertyId = 183;
			this._Id = "ratingValue";
			string label = "";
			GetLabel(out label, "RatingValue", typeof(RatingValue_Core));
			this._Label = label;
			this._Domains = new int[]{222};
			this._Ranges = new int[]{6};
		}
	}
}