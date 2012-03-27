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
	/// People working for this organization.
	/// </summary>
	public class Employees_Core : PropertyCore
	{
		public Employees_Core()
		{
			this._PropertyId = 77;
			this._Id = "employees";
			string label = "";
			GetLabel(out label, "Employees", typeof(Employees_Core));
			this._Label = label;
			this._Domains = new int[]{193};
			this._Ranges = new int[]{201};
		}
	}
}