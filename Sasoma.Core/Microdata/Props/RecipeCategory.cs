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
	/// The category of the recipe\u2014for example, appetizer, entree, etc.
	/// </summary>
	public class RecipeCategory_Core : PropertyCore
	{
		public RecipeCategory_Core()
		{
			this._PropertyId = 184;
			this._Id = "recipeCategory";
			string label = "";
			GetLabel(out label, "RecipeCategory", typeof(RecipeCategory_Core));
			this._Label = label;
			this._Domains = new int[]{224};
			this._Ranges = new int[]{6};
		}
	}
}