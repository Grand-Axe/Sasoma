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
	/// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in <a href=\http://en.wikipedia.org/wiki/ISO_3166\ target=\new\>ISO 3166 format</a>.
	/// </summary>
	public class RegionsAllowed_Core : PropertyCore
	{
		public RegionsAllowed_Core()
		{
			this._PropertyId = 188;
			this._Id = "regionsAllowed";
			string label = "";
			GetLabel(out label, "RegionsAllowed", typeof(RegionsAllowed_Core));
			this._Label = label;
			this._Domains = new int[]{161};
			this._Ranges = new int[]{206};
		}
	}
}