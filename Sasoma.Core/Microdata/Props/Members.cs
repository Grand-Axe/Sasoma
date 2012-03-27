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
	/// A member of this organization.
	/// </summary>
	public class Members_Core : PropertyCore
	{
		public Members_Core()
		{
			this._PropertyId = 137;
			this._Id = "members";
			string label = "";
			GetLabel(out label, "Members", typeof(Members_Core));
			this._Label = label;
			this._Domains = new int[]{193};
			this._Ranges = new int[]{201,193};
		}
	}
}