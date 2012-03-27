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
	/// A child of the person.
	/// </summary>
	public class Children_Core : PropertyCore
	{
		public Children_Core()
		{
			this._PropertyId = 43;
			this._Id = "children";
			string label = "";
			GetLabel(out label, "Children", typeof(Children_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{201};
		}
	}
}