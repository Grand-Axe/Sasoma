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
	/// The number of grams of unsaturated fat.
	/// </summary>
	public class UnsaturatedFatContent_Core : PropertyCore
	{
		public UnsaturatedFatContent_Core()
		{
			this._PropertyId = 227;
			this._Id = "unsaturatedFatContent";
			string label = "";
			GetLabel(out label, "UnsaturatedFatContent", typeof(UnsaturatedFatContent_Core));
			this._Label = label;
			this._Domains = new int[]{187};
			this._Ranges = new int[]{159};
		}
	}
}