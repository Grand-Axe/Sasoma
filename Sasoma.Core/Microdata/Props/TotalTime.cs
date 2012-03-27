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
	/// The total time it takes to prepare and cook the recipe, in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 duration format</a>.
	/// </summary>
	public class TotalTime_Core : PropertyCore
	{
		public TotalTime_Core()
		{
			this._PropertyId = 222;
			this._Id = "totalTime";
			string label = "";
			GetLabel(out label, "TotalTime", typeof(TotalTime_Core));
			this._Label = label;
			this._Domains = new int[]{224};
			this._Ranges = new int[]{86};
		}
	}
}