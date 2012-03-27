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
	/// The length of time it takes to prepare the recipe, in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 duration format</a>.
	/// </summary>
	public class PrepTime_Core : PropertyCore
	{
		public PrepTime_Core()
		{
			this._PropertyId = 164;
			this._Id = "prepTime";
			string label = "";
			GetLabel(out label, "PrepTime", typeof(PrepTime_Core));
			this._Label = label;
			this._Domains = new int[]{224};
			this._Ranges = new int[]{86};
		}
	}
}