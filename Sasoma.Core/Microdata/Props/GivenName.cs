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
	/// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the Name property.
	/// </summary>
	public class GivenName_Core : PropertyCore
	{
		public GivenName_Core()
		{
			this._PropertyId = 99;
			this._Id = "givenName";
			string label = "";
			GetLabel(out label, "GivenName", typeof(GivenName_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{6};
		}
	}
}