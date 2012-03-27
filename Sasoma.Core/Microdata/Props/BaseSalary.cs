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
	/// The base salary of the job.
	/// </summary>
	public class BaseSalary_Core : PropertyCore
	{
		public BaseSalary_Core()
		{
			this._PropertyId = 27;
			this._Id = "baseSalary";
			string label = "";
			GetLabel(out label, "BaseSalary", typeof(BaseSalary_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{5};
		}
	}
}