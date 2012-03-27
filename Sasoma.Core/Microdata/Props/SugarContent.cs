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
	/// The number of grams of sugar.
	/// </summary>
	public class SugarContent_Core : PropertyCore
	{
		public SugarContent_Core()
		{
			this._PropertyId = 217;
			this._Id = "sugarContent";
			string label = "";
			GetLabel(out label, "SugarContent", typeof(SugarContent_Core));
			this._Label = label;
			this._Domains = new int[]{187};
			this._Ranges = new int[]{159};
		}
	}
}