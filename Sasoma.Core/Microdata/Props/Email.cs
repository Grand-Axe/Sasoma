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
	/// Email address.
	/// </summary>
	public class Email_Core : PropertyCore
	{
		public Email_Core()
		{
			this._PropertyId = 75;
			this._Id = "email";
			string label = "";
			GetLabel(out label, "Email", typeof(Email_Core));
			this._Label = label;
			this._Domains = new int[]{193,70,201};
			this._Ranges = new int[]{6};
		}
	}
}