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
	/// The steps to make the dish.
	/// </summary>
	public class RecipeInstructions_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 186;
			}
		}

		public string Id
		{
			get
			{
				return "recipeInstructions";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "RecipeInstructions", typeof(RecipeInstructions_Core));
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