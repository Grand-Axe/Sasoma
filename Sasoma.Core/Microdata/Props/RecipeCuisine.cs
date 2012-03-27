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
	/// The cuisine of the recipe (for example, French or Ethopian).
	/// </summary>
	public class RecipeCuisine_Core : PropertyCore
	{
		public RecipeCuisine_Core()
		{
			this._PropertyId = 185;
			this._Id = "recipeCuisine";
			string label = "";
			GetLabel(out label, "RecipeCuisine", typeof(RecipeCuisine_Core));
			this._Label = label;
			this._Domains = new int[]{224};
			this._Ranges = new int[]{6};
		}
	}
}