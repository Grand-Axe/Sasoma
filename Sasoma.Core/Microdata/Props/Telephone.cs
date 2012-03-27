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
	/// The telephone number.
	/// </summary>
	public class Telephone_Core : PropertyCore
	{
		public Telephone_Core()
		{
			this._PropertyId = 196;
			this._Id = "telephone";
			string label = "";
			GetLabel(out label, "Telephone", typeof(Telephone_Core));
			this._Label = label;
			this._Domains = new int[]{193,70,206,201};
			this._Ranges = new int[]{6};
		}
	}
}