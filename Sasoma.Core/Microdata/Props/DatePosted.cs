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
	/// Publication date for the job posting.
	/// </summary>
	public class DatePosted_Core : PropertyCore
	{
		public DatePosted_Core()
		{
			this._PropertyId = 63;
			this._Id = "datePosted";
			string label = "";
			GetLabel(out label, "DatePosted", typeof(DatePosted_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{2};
		}
	}
}