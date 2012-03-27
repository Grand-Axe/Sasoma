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
	/// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
	/// </summary>
	public class EmploymentType_Core : PropertyCore
	{
		public EmploymentType_Core()
		{
			this._PropertyId = 78;
			this._Id = "employmentType";
			string label = "";
			GetLabel(out label, "EmploymentType", typeof(EmploymentType_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{6};
		}
	}
}