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
	/// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the Name property.
	/// </summary>
	public class FamilyName_Core : PropertyCore
	{
		public FamilyName_Core()
		{
			this._PropertyId = 89;
			this._Id = "familyName";
			string label = "";
			GetLabel(out label, "FamilyName", typeof(FamilyName_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{6};
		}
	}
}