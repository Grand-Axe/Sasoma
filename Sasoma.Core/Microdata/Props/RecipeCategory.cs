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
	/// The category of the recipe\u2014for example, appetizer, entree, etc.
	/// </summary>
	public class RecipeCategory_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 184;
			}
		}

		public string Id
		{
			get
			{
				return "recipeCategory";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "RecipeCategory", typeof(RecipeCategory_Core));
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