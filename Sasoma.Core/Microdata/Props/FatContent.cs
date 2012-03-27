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
	/// The number of grams of fat.
	/// </summary>
	public class FatContent_Core : PropertyCore
	{
		public FatContent_Core()
		{
			this._PropertyId = 90;
			this._Id = "fatContent";
			string label = "";
			GetLabel(out label, "FatContent", typeof(FatContent_Core));
			this._Label = label;
			this._Domains = new int[]{187};
			this._Ranges = new int[]{159};
		}
	}
}