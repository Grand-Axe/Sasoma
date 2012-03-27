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
	/// A contact location for a person's residence.
	/// </summary>
	public class HomeLocation_Core : PropertyCore
	{
		public HomeLocation_Core()
		{
			this._PropertyId = 104;
			this._Id = "homeLocation";
			string label = "";
			GetLabel(out label, "HomeLocation", typeof(HomeLocation_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{206,70};
		}
	}
}