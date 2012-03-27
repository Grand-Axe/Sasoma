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
	/// The elevation of a location.
	/// </summary>
	public class Elevation_Core : PropertyCore
	{
		public Elevation_Core()
		{
			this._PropertyId = 74;
			this._Id = "elevation";
			string label = "";
			GetLabel(out label, "Elevation", typeof(Elevation_Core));
			this._Label = label;
			this._Domains = new int[]{114,113};
			this._Ranges = new int[]{6,5};
		}
	}
}