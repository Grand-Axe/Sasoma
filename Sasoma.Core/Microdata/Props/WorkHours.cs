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
	/// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
	/// </summary>
	public class WorkHours_Core : PropertyCore
	{
		public WorkHours_Core()
		{
			this._PropertyId = 236;
			this._Id = "workHours";
			string label = "";
			GetLabel(out label, "WorkHours", typeof(WorkHours_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{6};
		}
	}
}