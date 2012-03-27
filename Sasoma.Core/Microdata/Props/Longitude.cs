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
	/// The longitude of a location. For example <code>-122.08585</code>.
	/// </summary>
	public class Longitude_Core : PropertyCore
	{
		public Longitude_Core()
		{
			this._PropertyId = 131;
			this._Id = "longitude";
			string label = "";
			GetLabel(out label, "Longitude", typeof(Longitude_Core));
			this._Label = label;
			this._Domains = new int[]{113};
			this._Ranges = new int[]{5,6};
		}
	}
}