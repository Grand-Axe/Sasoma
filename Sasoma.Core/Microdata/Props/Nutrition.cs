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
	/// Nutrition information about the recipe.
	/// </summary>
	public class Nutrition_Core : PropertyCore
	{
		public Nutrition_Core()
		{
			this._PropertyId = 148;
			this._Id = "nutrition";
			string label = "";
			GetLabel(out label, "Nutrition", typeof(Nutrition_Core));
			this._Label = label;
			this._Domains = new int[]{224};
			this._Ranges = new int[]{187};
		}
	}
}