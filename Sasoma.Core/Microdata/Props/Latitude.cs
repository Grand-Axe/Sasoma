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
	/// The latitude of a location. For example <code>37.42242</code>.
	/// </summary>
	public class Latitude_Core : PropertyCore
	{
		public Latitude_Core()
		{
			this._PropertyId = 128;
			this._Id = "latitude";
			string label = "";
			GetLabel(out label, "Latitude", typeof(Latitude_Core));
			this._Label = label;
			this._Domains = new int[]{113};
			this._Ranges = new int[]{5,6};
		}
	}
}