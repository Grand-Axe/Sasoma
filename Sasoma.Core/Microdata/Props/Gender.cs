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
	/// Gender of the person.
	/// </summary>
	public class Gender_Core : PropertyCore
	{
		public Gender_Core()
		{
			this._PropertyId = 96;
			this._Id = "gender";
			string label = "";
			GetLabel(out label, "Gender", typeof(Gender_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{6};
		}
	}
}