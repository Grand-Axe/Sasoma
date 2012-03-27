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
	/// Official rating of a piece of content\u2014for example,'MPAA PG-13'.
	/// </summary>
	public class ContentRating_Core : PropertyCore
	{
		public ContentRating_Core()
		{
			this._PropertyId = 51;
			this._Id = "contentRating";
			string label = "";
			GetLabel(out label, "ContentRating", typeof(ContentRating_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{6};
		}
	}
}