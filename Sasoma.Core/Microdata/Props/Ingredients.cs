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
	/// An ingredient used in the recipe.
	/// </summary>
	public class Ingredients_Core : PropertyCore
	{
		public Ingredients_Core()
		{
			this._PropertyId = 114;
			this._Id = "ingredients";
			string label = "";
			GetLabel(out label, "Ingredients", typeof(Ingredients_Core));
			this._Label = label;
			this._Domains = new int[]{224};
			this._Ranges = new int[]{6};
		}
	}
}