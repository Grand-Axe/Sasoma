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
	/// The currency (coded using ISO 4217, http://en.wikipedia.org/wiki/ISO_4217 used for the main salary information in this job posting.
	/// </summary>
	public class SalaryCurrency_Core : PropertyCore
	{
		public SalaryCurrency_Core()
		{
			this._PropertyId = 200;
			this._Id = "salaryCurrency";
			string label = "";
			GetLabel(out label, "SalaryCurrency", typeof(SalaryCurrency_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{6};
		}
	}
}