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
	/// The date on which the CreativeWork was most recently modified.
	/// </summary>
	public class DateModified_Core : PropertyCore
	{
		public DateModified_Core()
		{
			this._PropertyId = 62;
			this._Id = "dateModified";
			string label = "";
			GetLabel(out label, "DateModified", typeof(DateModified_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{2};
		}
	}
}