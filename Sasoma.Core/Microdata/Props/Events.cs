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
	/// Upcoming or past events associated with this place or organization.
	/// </summary>
	public class Events_Core : PropertyCore
	{
		public Events_Core()
		{
			this._PropertyId = 85;
			this._Id = "events";
			string label = "";
			GetLabel(out label, "Events", typeof(Events_Core));
			this._Label = label;
			this._Domains = new int[]{193,206};
			this._Ranges = new int[]{98};
		}
	}
}