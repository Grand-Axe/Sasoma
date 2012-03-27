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
	/// The steps to make the dish.
	/// </summary>
	public class RecipeInstructions_Core : PropertyCore
	{
		public RecipeInstructions_Core()
		{
			this._PropertyId = 186;
			this._Id = "recipeInstructions";
			string label = "";
			GetLabel(out label, "RecipeInstructions", typeof(RecipeInstructions_Core));
			this._Label = label;
			this._Domains = new int[]{224};
			this._Ranges = new int[]{6};
		}
	}
}