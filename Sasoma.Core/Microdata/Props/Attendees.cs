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
	/// A person attending the event.
	/// </summary>
	public class Attendees_Core : PropertyCore
	{
		public Attendees_Core()
		{
			this._PropertyId = 19;
			this._Id = "attendees";
			string label = "";
			GetLabel(out label, "Attendees", typeof(Attendees_Core));
			this._Label = label;
			this._Domains = new int[]{98};
			this._Ranges = new int[]{201,193};
		}
	}
}