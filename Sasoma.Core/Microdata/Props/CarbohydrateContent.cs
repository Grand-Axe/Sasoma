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
	/// The number of grams of carbohydrates.
	/// </summary>
	public class CarbohydrateContent_Core : PropertyCore
	{
		public CarbohydrateContent_Core()
		{
			this._PropertyId = 42;
			this._Id = "carbohydrateContent";
			string label = "";
			GetLabel(out label, "CarbohydrateContent", typeof(CarbohydrateContent_Core));
			this._Label = label;
			this._Domains = new int[]{187};
			this._Ranges = new int[]{159};
		}
	}
}