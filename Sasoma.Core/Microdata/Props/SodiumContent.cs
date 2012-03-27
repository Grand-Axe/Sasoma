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
	/// The number of milligrams of sodium.
	/// </summary>
	public class SodiumContent_Core : PropertyCore
	{
		public SodiumContent_Core()
		{
			this._PropertyId = 210;
			this._Id = "sodiumContent";
			string label = "";
			GetLabel(out label, "SodiumContent", typeof(SodiumContent_Core));
			this._Label = label;
			this._Domains = new int[]{187};
			this._Ranges = new int[]{159};
		}
	}
}