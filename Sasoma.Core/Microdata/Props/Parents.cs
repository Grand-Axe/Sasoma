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
	/// A parents of the person.
	/// </summary>
	public class Parents_Core : PropertyCore
	{
		public Parents_Core()
		{
			this._PropertyId = 153;
			this._Id = "parents";
			string label = "";
			GetLabel(out label, "Parents", typeof(Parents_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{201};
		}
	}
}