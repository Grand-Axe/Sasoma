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
	/// An ingredient used in the recipe.
	/// </summary>
	public class Ingredients_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 114;
			}
		}

		public string Id
		{
			get
			{
				return "ingredients";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Ingredients", typeof(Ingredients_Core));
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