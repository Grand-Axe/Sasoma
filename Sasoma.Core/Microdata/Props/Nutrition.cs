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
	/// Nutrition information about the recipe.
	/// </summary>
	public class Nutrition_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 148;
			}
		}

		public string Id
		{
			get
			{
				return "nutrition";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Nutrition", typeof(Nutrition_Core));
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
				return new int[]{187};
			}
		}

	}
}