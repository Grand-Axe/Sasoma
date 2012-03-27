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
	/// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
	/// </summary>
	public class Affiliation_Core : PropertyCore
	{
		public Affiliation_Core()
		{
			this._PropertyId = 9;
			this._Id = "affiliation";
			string label = "";
			GetLabel(out label, "Affiliation", typeof(Affiliation_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{193};
		}
	}
}