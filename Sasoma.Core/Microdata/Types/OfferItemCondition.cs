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
	/// A list of possible conditions for the item for sale.
	/// </summary>
	public class OfferItemCondition_Core : TypeCore, IEnumeration
	{
		public OfferItemCondition_Core()
		{
			this._TypeId = 190;
			this._Id = "OfferItemCondition";
			this._Schema_Org_Url = "http://schema.org/OfferItemCondition";
			string label = "";
			GetLabel(out label, "OfferItemCondition", typeof(OfferItemCondition_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138,97};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{97};
			this._Properties = new int[]{67,108,143,229};

		}

		/// <summary>
		/// A short description of the item.
		/// </summary>
		public Description_Core Description { get; set; }

		/// <summary>
		/// URL of an image of the item.
		/// </summary>
		public Image_Core Image { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		public Properties.URL_Core URL { get; set; }

	}
}