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
	/// Nationality of the person.
	/// </summary>
	public class Nationality_Core : PropertyCore
	{
		public Nationality_Core()
		{
			this._PropertyId = 144;
			this._Id = "nationality";
			string label = "";
			GetLabel(out label, "Nationality", typeof(Nationality_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{74};
		}
	}
}