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
	/// Date of birth.
	/// </summary>
	public class BirthDate_Core : PropertyCore
	{
		public BirthDate_Core()
		{
			this._PropertyId = 30;
			this._Id = "birthDate";
			string label = "";
			GetLabel(out label, "BirthDate", typeof(BirthDate_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{2};
		}
	}
}