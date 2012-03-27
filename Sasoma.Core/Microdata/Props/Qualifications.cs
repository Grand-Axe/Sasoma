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
	/// Specific qualifications required for this role.
	/// </summary>
	public class Qualifications_Core : PropertyCore
	{
		public Qualifications_Core()
		{
			this._PropertyId = 181;
			this._Id = "qualifications";
			string label = "";
			GetLabel(out label, "Qualifications", typeof(Qualifications_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{6};
		}
	}
}