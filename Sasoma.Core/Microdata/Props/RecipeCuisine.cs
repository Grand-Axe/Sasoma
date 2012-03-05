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
	/// The cuisine of the recipe (for example, French or Ethopian).
	/// </summary>
	public class RecipeCuisine_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 185;
			}
		}

		public string Id
		{
			get
			{
				return "recipeCuisine";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "RecipeCuisine", typeof(RecipeCuisine_Core));
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