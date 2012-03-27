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
	/// The street address. For example, 1600 Amphitheatre Pkwy.
	/// </summary>
	public class StreetAddress_Core : PropertyCore
	{
		public StreetAddress_Core()
		{
			this._PropertyId = 215;
			this._Id = "streetAddress";
			string label = "";
			GetLabel(out label, "StreetAddress", typeof(StreetAddress_Core));
			this._Label = label;
			this._Domains = new int[]{213};
			this._Ranges = new int[]{6};
		}
	}
}