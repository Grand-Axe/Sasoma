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
	/// The person's spouse.
	/// </summary>
	public class Spouse_Core : PropertyCore
	{
		public Spouse_Core()
		{
			this._PropertyId = 213;
			this._Id = "spouse";
			string label = "";
			GetLabel(out label, "Spouse", typeof(Spouse_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{201};
		}
	}
}