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
	/// The most significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most
	/// </summary>
	public class SignificantLinks_Core : PropertyCore
	{
		public SignificantLinks_Core()
		{
			this._PropertyId = 208;
			this._Id = "significantLinks";
			string label = "";
			GetLabel(out label, "SignificantLinks", typeof(SignificantLinks_Core));
			this._Label = label;
			this._Domains = new int[]{293};
			this._Ranges = new int[]{7};
		}
	}
}