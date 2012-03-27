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
	/// The number of grams of saturated fat.
	/// </summary>
	public class SaturatedFatContent_Core : PropertyCore
	{
		public SaturatedFatContent_Core()
		{
			this._PropertyId = 201;
			this._Id = "saturatedFatContent";
			string label = "";
			GetLabel(out label, "SaturatedFatContent", typeof(SaturatedFatContent_Core));
			this._Label = label;
			this._Domains = new int[]{187};
			this._Ranges = new int[]{159};
		}
	}
}