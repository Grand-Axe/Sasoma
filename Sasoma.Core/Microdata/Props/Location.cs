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
	/// The location of the event or organization.
	/// </summary>
	public class Location_Core : PropertyCore
	{
		public Location_Core()
		{
			this._PropertyId = 130;
			this._Id = "location";
			string label = "";
			GetLabel(out label, "Location", typeof(Location_Core));
			this._Label = label;
			this._Domains = new int[]{193,98};
			this._Ranges = new int[]{213,206};
		}
	}
}