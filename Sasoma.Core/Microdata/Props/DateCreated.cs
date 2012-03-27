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
	/// The date on which the CreativeWork was created.
	/// </summary>
	public class DateCreated_Core : PropertyCore
	{
		public DateCreated_Core()
		{
			this._PropertyId = 61;
			this._Id = "dateCreated";
			string label = "";
			GetLabel(out label, "DateCreated", typeof(DateCreated_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{2};
		}
	}
}