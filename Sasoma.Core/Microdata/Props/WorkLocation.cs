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
	/// A contact location for a person's place of work.
	/// </summary>
	public class WorkLocation_Core : PropertyCore
	{
		public WorkLocation_Core()
		{
			this._PropertyId = 237;
			this._Id = "workLocation";
			string label = "";
			GetLabel(out label, "WorkLocation", typeof(WorkLocation_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{206,70};
		}
	}
}