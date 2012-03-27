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
	/// The geo coordinates of the place.
	/// </summary>
	public class Geo_Core : PropertyCore
	{
		public Geo_Core()
		{
			this._PropertyId = 98;
			this._Id = "geo";
			string label = "";
			GetLabel(out label, "Geo", typeof(Geo_Core));
			this._Label = label;
			this._Domains = new int[]{206};
			this._Ranges = new int[]{113,114};
		}
	}
}