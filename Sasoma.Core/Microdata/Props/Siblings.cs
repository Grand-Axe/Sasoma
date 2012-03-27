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
	/// A sibling of the person.
	/// </summary>
	public class Siblings_Core : PropertyCore
	{
		public Siblings_Core()
		{
			this._PropertyId = 207;
			this._Id = "siblings";
			string label = "";
			GetLabel(out label, "Siblings", typeof(Siblings_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{201};
		}
	}
}