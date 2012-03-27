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
	/// Indicates the collection or gallery to which the item belongs.
	/// </summary>
	public class IsPartOf_Core : PropertyCore
	{
		public IsPartOf_Core()
		{
			this._PropertyId = 117;
			this._Id = "isPartOf";
			string label = "";
			GetLabel(out label, "IsPartOf", typeof(IsPartOf_Core));
			this._Label = label;
			this._Domains = new int[]{293};
			this._Ranges = new int[]{64};
		}
	}
}