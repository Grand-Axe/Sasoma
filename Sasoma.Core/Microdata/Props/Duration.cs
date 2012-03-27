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
	/// The duration of the item (movie, audio recording, event, etc.) in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>.
	/// </summary>
	public class Duration_Core : PropertyCore
	{
		public Duration_Core()
		{
			this._PropertyId = 71;
			this._Id = "duration";
			string label = "";
			GetLabel(out label, "Duration", typeof(Duration_Core));
			this._Label = label;
			this._Domains = new int[]{169,161,178,98};
			this._Ranges = new int[]{86};
		}
	}
}