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
	/// The number of grams of carbohydrates.
	/// </summary>
	public class CarbohydrateContent_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 42;
			}
		}

		public string Id
		{
			get
			{
				return "carbohydrateContent";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "CarbohydrateContent", typeof(CarbohydrateContent_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{187};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{159};
			}
		}

	}
}