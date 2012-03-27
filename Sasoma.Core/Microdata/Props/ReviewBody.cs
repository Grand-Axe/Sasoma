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
	/// The actual body of the review
	/// </summary>
	public class ReviewBody_Core : PropertyCore
	{
		public ReviewBody_Core()
		{
			this._PropertyId = 194;
			this._Id = "reviewBody";
			string label = "";
			GetLabel(out label, "ReviewBody", typeof(ReviewBody_Core));
			this._Label = label;
			this._Domains = new int[]{229};
			this._Ranges = new int[]{6};
		}
	}
}