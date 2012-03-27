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
	/// The start date and time of the event (in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>).
	/// </summary>
	public class StartDate_Core : PropertyCore
	{
		public StartDate_Core()
		{
			this._PropertyId = 214;
			this._Id = "startDate";
			string label = "";
			GetLabel(out label, "StartDate", typeof(StartDate_Core));
			this._Label = label;
			this._Domains = new int[]{257,98,258};
			this._Ranges = new int[]{2};
		}
	}
}