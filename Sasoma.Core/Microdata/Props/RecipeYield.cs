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
	/// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
	/// </summary>
	public class RecipeYield_Core : PropertyCore
	{
		public RecipeYield_Core()
		{
			this._PropertyId = 187;
			this._Id = "recipeYield";
			string label = "";
			GetLabel(out label, "RecipeYield", typeof(RecipeYield_Core));
			this._Label = label;
			this._Domains = new int[]{224};
			this._Ranges = new int[]{6};
		}
	}
}