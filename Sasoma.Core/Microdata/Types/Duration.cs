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
	/// Quantity: Duration (use  <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 duration format</a>).
	/// </summary>
	public class Duration_Core : TypeCore, IQuantity
	{
		public Duration_Core()
		{
			this._TypeId = 86;
			this._Id = "Duration";
			this._Schema_Org_Url = "http://schema.org/Duration";
			string label = "";
			GetLabel(out label, "Duration", typeof(Duration_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138,219};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{219};
			this._Properties = new int[0];

		}

        public Description_Core Description { get; set; }
        public Image_Core Image { get; set; }
        public Name_Core Name { get; set; }
        public Properties.URL_Core URL { get; set; }
	}
}