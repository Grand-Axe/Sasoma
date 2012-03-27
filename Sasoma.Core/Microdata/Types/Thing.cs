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
	/// The most generic type of item.
	/// </summary>
    public class Thing_Core : TypeCore, IThing
	{
		public Thing_Core()
		{
			this._TypeId = 266;
			this._Id = "Thing";
			this._Schema_Org_Url = "http://schema.org/Thing";
			string label = "";
			GetLabel(out label, "Thing", typeof(Thing_Core));
			this._Label = label;
			this._Ancestors = new int[0];
			this._SubTypes = new int[]{78,98,138,193,201,206,215};
			this._SuperTypes = new int[0];
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