using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Interfaces;

namespace Sasoma.Microdata.Properties
{
	/// <summary>
	/// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
	/// </summary>
	public class RecipeYield_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 187;
			}
		}

		public string Id
		{
			get
			{
				return "recipeYield";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "RecipeYield", typeof(RecipeYield_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{224};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{6};
			}
		}

	}
}