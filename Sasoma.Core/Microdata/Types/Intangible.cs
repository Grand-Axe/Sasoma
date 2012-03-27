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
	/// A utility class that serves as the umbrella for a number of 'intangible' things such as quantities, structured values, etc.
	/// </summary>
	public class Intangible_Core : TypeCore, IThing
	{
		public Intangible_Core()
		{
			this._TypeId = 138;
			this._Id = "Intangible";
			this._Schema_Org_Url = "http://schema.org/Intangible";
			string label = "";
			GetLabel(out label, "Intangible", typeof(Intangible_Core));
			this._Label = label;
			this._Ancestors = new int[]{266};
			this._SubTypes = new int[]{97,144,148,189,219,222,253};
			this._SuperTypes = new int[]{266};
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