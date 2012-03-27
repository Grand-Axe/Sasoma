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
	/// The fax number.
	/// </summary>
	public class FaxNumber_Core : PropertyCore
	{
		public FaxNumber_Core()
		{
			this._PropertyId = 91;
			this._Id = "faxNumber";
			string label = "";
			GetLabel(out label, "FaxNumber", typeof(FaxNumber_Core));
			this._Label = label;
			this._Domains = new int[]{193,70,206,201};
			this._Ranges = new int[]{6};
		}
	}
}