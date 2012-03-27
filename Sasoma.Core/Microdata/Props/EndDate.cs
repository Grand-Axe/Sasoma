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
	/// The end date and time of the event (in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>).
	/// </summary>
	public class EndDate_Core : PropertyCore
	{
		public EndDate_Core()
		{
			this._PropertyId = 82;
			this._Id = "endDate";
			string label = "";
			GetLabel(out label, "EndDate", typeof(EndDate_Core));
			this._Label = label;
			this._Domains = new int[]{257,98,258};
			this._Ranges = new int[]{2};
		}
	}
}