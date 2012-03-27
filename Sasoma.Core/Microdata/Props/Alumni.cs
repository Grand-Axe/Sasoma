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
	/// Alumni of educational organization.
	/// </summary>
	public class Alumni_Core : PropertyCore
	{
		public Alumni_Core()
		{
			this._PropertyId = 13;
			this._Id = "alumni";
			string label = "";
			GetLabel(out label, "Alumni", typeof(Alumni_Core));
			this._Label = label;
			this._Domains = new int[]{88};
			this._Ranges = new int[]{201};
		}
	}
}