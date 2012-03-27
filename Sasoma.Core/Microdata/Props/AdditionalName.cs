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
	/// An additional name for a Person, can be used for a middle name.
	/// </summary>
	public class AdditionalName_Core : PropertyCore
	{
		public AdditionalName_Core()
		{
			this._PropertyId = 4;
			this._Id = "additionalName";
			string label = "";
			GetLabel(out label, "AdditionalName", typeof(AdditionalName_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{6};
		}
	}
}