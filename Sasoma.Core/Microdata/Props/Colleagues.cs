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
	/// A colleague of the person.
	/// </summary>
	public class Colleagues_Core : PropertyCore
	{
		public Colleagues_Core()
		{
			this._PropertyId = 46;
			this._Id = "colleagues";
			string label = "";
			GetLabel(out label, "Colleagues", typeof(Colleagues_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{201};
		}
	}
}