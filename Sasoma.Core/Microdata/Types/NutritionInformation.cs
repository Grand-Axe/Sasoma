using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Microdata.Interfaces;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Types
{
	/// <summary>
	/// Nutritional information about the recipe.
	/// </summary>
	public class NutritionInformation_Core : TypeCore, IStructuredValue
	{
		public NutritionInformation_Core()
		{
			this._TypeId = 187;
			this._Id = "NutritionInformation";
			this._Schema_Org_Url = "http://schema.org/NutritionInformation";
			string label = "";
			GetLabel(out label, "NutritionInformation", typeof(NutritionInformation_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138,253};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{253};
			this._Properties = new int[]{67,108,143,229,40,42,44,90,92,177,201,206,210,217,225,227};

		}

		/// <summary>
		/// The number of calories
		/// </summary>
		public Calories_Core Calories { get; set; }

		/// <summary>
		/// The number of grams of carbohydrates.
		/// </summary>
		public CarbohydrateContent_Core CarbohydrateContent { get; set; }

		/// <summary>
		/// The number of milligrams of cholesterol.
		/// </summary>
		public CholesterolContent_Core CholesterolContent { get; set; }

		/// <summary>
		/// A short description of the item.
		/// </summary>
		public Description_Core Description { get; set; }

		/// <summary>
		/// The number of grams of fat.
		/// </summary>
		public FatContent_Core FatContent { get; set; }

		/// <summary>
		/// The number of grams of fiber.
		/// </summary>
		public FiberContent_Core FiberContent { get; set; }

		/// <summary>
		/// URL of an image of the item.
		/// </summary>
		public Image_Core Image { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// The number of grams of protein.
		/// </summary>
		public ProteinContent_Core ProteinContent { get; set; }

		/// <summary>
		/// The number of grams of saturated fat.
		/// </summary>
		public SaturatedFatContent_Core SaturatedFatContent { get; set; }

		/// <summary>
		/// The serving size, in terms of the number of volume or mass
		/// </summary>
		public ServingSize_Core ServingSize { get; set; }

		/// <summary>
		/// The number of milligrams of sodium.
		/// </summary>
		public SodiumContent_Core SodiumContent { get; set; }

		/// <summary>
		/// The number of grams of sugar.
		/// </summary>
		public SugarContent_Core SugarContent { get; set; }

		/// <summary>
		/// The number of grams of trans fat.
		/// </summary>
		public TransFatContent_Core TransFatContent { get; set; }

		/// <summary>
		/// The number of grams of unsaturated fat.
		/// </summary>
		public UnsaturatedFatContent_Core UnsaturatedFatContent { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		public Properties.URL_Core URL { get; set; }

	}
}