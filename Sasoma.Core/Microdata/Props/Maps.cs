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
	/// A URL to a map of the place.
	/// </summary>
	public class Maps_Core : PropertyCore
	{
		public Maps_Core()
		{
			this._PropertyId = 135;
			this._Id = "maps";
			string label = "";
			GetLabel(out label, "Maps", typeof(Maps_Core));
			this._Label = label;
			this._Domains = new int[]{206};
			this._Ranges = new int[]{7};
		}
	}
}