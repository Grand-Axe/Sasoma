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
	/// The date that this organization was founded.
	/// </summary>
	public class FoundingDate_Core : PropertyCore
	{
		public FoundingDate_Core()
		{
			this._PropertyId = 95;
			this._Id = "foundingDate";
			string label = "";
			GetLabel(out label, "FoundingDate", typeof(FoundingDate_Core));
			this._Label = label;
			this._Domains = new int[]{193};
			this._Ranges = new int[]{2};
		}
	}
}