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
		private Calories_Core calories;
		public Calories_Core Calories
		{
			get
			{
				return calories;
			}
			set
			{
				calories = value;
				SetPropertyInstance(calories);
			}
		}

		/// <summary>
		/// The number of grams of carbohydrates.
		/// </summary>
		private CarbohydrateContent_Core carbohydrateContent;
		public CarbohydrateContent_Core CarbohydrateContent
		{
			get
			{
				return carbohydrateContent;
			}
			set
			{
				carbohydrateContent = value;
				SetPropertyInstance(carbohydrateContent);
			}
		}

		/// <summary>
		/// The number of milligrams of cholesterol.
		/// </summary>
		private CholesterolContent_Core cholesterolContent;
		public CholesterolContent_Core CholesterolContent
		{
			get
			{
				return cholesterolContent;
			}
			set
			{
				cholesterolContent = value;
				SetPropertyInstance(cholesterolContent);
			}
		}

		/// <summary>
		/// A short description of the item.
		/// </summary>
		private Description_Core description;
		public Description_Core Description
		{
			get
			{
				return description;
			}
			set
			{
				description = value;
				SetPropertyInstance(description);
			}
		}

		/// <summary>
		/// The number of grams of fat.
		/// </summary>
		private FatContent_Core fatContent;
		public FatContent_Core FatContent
		{
			get
			{
				return fatContent;
			}
			set
			{
				fatContent = value;
				SetPropertyInstance(fatContent);
			}
		}

		/// <summary>
		/// The number of grams of fiber.
		/// </summary>
		private FiberContent_Core fiberContent;
		public FiberContent_Core FiberContent
		{
			get
			{
				return fiberContent;
			}
			set
			{
				fiberContent = value;
				SetPropertyInstance(fiberContent);
			}
		}

		/// <summary>
		/// URL of an image of the item.
		/// </summary>
		private Image_Core image;
		public Image_Core Image
		{
			get
			{
				return image;
			}
			set
			{
				image = value;
				SetPropertyInstance(image);
			}
		}

		/// <summary>
		/// The name of the item.
		/// </summary>
		private Name_Core name;
		public Name_Core Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
				SetPropertyInstance(name);
			}
		}

		/// <summary>
		/// The number of grams of protein.
		/// </summary>
		private ProteinContent_Core proteinContent;
		public ProteinContent_Core ProteinContent
		{
			get
			{
				return proteinContent;
			}
			set
			{
				proteinContent = value;
				SetPropertyInstance(proteinContent);
			}
		}

		/// <summary>
		/// The number of grams of saturated fat.
		/// </summary>
		private SaturatedFatContent_Core saturatedFatContent;
		public SaturatedFatContent_Core SaturatedFatContent
		{
			get
			{
				return saturatedFatContent;
			}
			set
			{
				saturatedFatContent = value;
				SetPropertyInstance(saturatedFatContent);
			}
		}

		/// <summary>
		/// The serving size, in terms of the number of volume or mass
		/// </summary>
		private ServingSize_Core servingSize;
		public ServingSize_Core ServingSize
		{
			get
			{
				return servingSize;
			}
			set
			{
				servingSize = value;
				SetPropertyInstance(servingSize);
			}
		}

		/// <summary>
		/// The number of milligrams of sodium.
		/// </summary>
		private SodiumContent_Core sodiumContent;
		public SodiumContent_Core SodiumContent
		{
			get
			{
				return sodiumContent;
			}
			set
			{
				sodiumContent = value;
				SetPropertyInstance(sodiumContent);
			}
		}

		/// <summary>
		/// The number of grams of sugar.
		/// </summary>
		private SugarContent_Core sugarContent;
		public SugarContent_Core SugarContent
		{
			get
			{
				return sugarContent;
			}
			set
			{
				sugarContent = value;
				SetPropertyInstance(sugarContent);
			}
		}

		/// <summary>
		/// The number of grams of trans fat.
		/// </summary>
		private TransFatContent_Core transFatContent;
		public TransFatContent_Core TransFatContent
		{
			get
			{
				return transFatContent;
			}
			set
			{
				transFatContent = value;
				SetPropertyInstance(transFatContent);
			}
		}

		/// <summary>
		/// The number of grams of unsaturated fat.
		/// </summary>
		private UnsaturatedFatContent_Core unsaturatedFatContent;
		public UnsaturatedFatContent_Core UnsaturatedFatContent
		{
			get
			{
				return unsaturatedFatContent;
			}
			set
			{
				unsaturatedFatContent = value;
				SetPropertyInstance(unsaturatedFatContent);
			}
		}

		/// <summary>
		/// URL of the item.
		/// </summary>
		private Properties.URL_Core uRL;
		public Properties.URL_Core URL
		{
			get
			{
				return uRL;
			}
			set
			{
				uRL = value;
				SetPropertyInstance(uRL);
			}
		}

	}
}