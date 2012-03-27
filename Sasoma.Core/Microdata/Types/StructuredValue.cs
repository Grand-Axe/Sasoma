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
	/// Structured values are strings\u2014for example, addresses\u2014that have certain constraints on their structure.
	/// </summary>
	public class StructuredValue_Core : TypeCore, IIntangible
	{
		public StructuredValue_Core()
		{
			this._TypeId = 253;
			this._Id = "StructuredValue";
			this._Schema_Org_Url = "http://schema.org/StructuredValue";
			string label = "";
			GetLabel(out label, "StructuredValue", typeof(StructuredValue_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138};
			this._SubTypes = new int[]{70,113,114,187};
			this._SuperTypes = new int[]{138};
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