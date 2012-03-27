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
	/// The time it takes to actually cook the dish, in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 duration format</a>.
	/// </summary>
	public class CookTime_Core : PropertyCore
	{
		public CookTime_Core()
		{
			this._PropertyId = 55;
			this._Id = "cookTime";
			string label = "";
			GetLabel(out label, "CookTime", typeof(CookTime_Core));
			this._Label = label;
			this._Domains = new int[]{224};
			this._Ranges = new int[]{86};
		}
	}
}