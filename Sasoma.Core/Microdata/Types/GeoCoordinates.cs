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
	/// The geographic coordinates of a place or event.
	/// </summary>
	public class GeoCoordinates_Core : TypeCore, IStructuredValue
	{
		public GeoCoordinates_Core()
		{
			this._TypeId = 113;
			this._Id = "GeoCoordinates";
			this._Schema_Org_Url = "http://schema.org/GeoCoordinates";
			string label = "";
			GetLabel(out label, "GeoCoordinates", typeof(GeoCoordinates_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138,253};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{253};
			this._Properties = new int[]{67,108,143,229,74,128,131};

		}

		/// <summary>
		/// A short description of the item.
		/// </summary>
		public Description_Core Description { get; set; }

		/// <summary>
		/// The elevation of a location.
		/// </summary>
		public Elevation_Core Elevation { get; set; }

		/// <summary>
		/// URL of an image of the item.
		/// </summary>
		public Image_Core Image { get; set; }

		/// <summary>
		/// The latitude of a location. For example <code>37.42242</code>.
		/// </summary>
		public Latitude_Core Latitude { get; set; }

		/// <summary>
		/// The longitude of a location. For example <code>-122.08585</code>.
		/// </summary>
		public Longitude_Core Longitude { get; set; }

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