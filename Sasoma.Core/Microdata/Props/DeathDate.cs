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
	/// Date of death.
	/// </summary>
	public class DeathDate_Core : PropertyCore
	{
		public DeathDate_Core()
		{
			this._PropertyId = 66;
			this._Id = "deathDate";
			string label = "";
			GetLabel(out label, "DeathDate", typeof(DeathDate_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{2};
		}
	}
}