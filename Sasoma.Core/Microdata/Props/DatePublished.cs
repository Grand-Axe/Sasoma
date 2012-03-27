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
	/// Date of first broadcast/publication.
	/// </summary>
	public class DatePublished_Core : PropertyCore
	{
		public DatePublished_Core()
		{
			this._PropertyId = 64;
			this._Id = "datePublished";
			string label = "";
			GetLabel(out label, "DatePublished", typeof(DatePublished_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{2};
		}
	}
}