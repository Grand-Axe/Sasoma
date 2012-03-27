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
	/// Properties that take Distances as values are of the form '<Number> <Length unit of measure>'. E.g., '7 ft'
	/// </summary>
	public class Distance_Core : TypeCore, IQuantity
	{
		public Distance_Core()
		{
			this._TypeId = 76;
			this._Id = "Distance";
			this._Schema_Org_Url = "http://schema.org/Distance";
			string label = "";
			GetLabel(out label, "Distance", typeof(Distance_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138,219};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{219};
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