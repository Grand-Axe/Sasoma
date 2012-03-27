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
	/// Organizations that the person works for.
	/// </summary>
	public class WorksFor_Core : PropertyCore
	{
		public WorksFor_Core()
		{
			this._PropertyId = 238;
			this._Id = "worksFor";
			string label = "";
			GetLabel(out label, "WorksFor", typeof(WorksFor_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{193};
		}
	}
}