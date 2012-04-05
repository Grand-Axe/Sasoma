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
		/// The elevation of a location.
		/// </summary>
		private Elevation_Core elevation;
		public Elevation_Core Elevation
		{
			get
			{
				return elevation;
			}
			set
			{
				elevation = value;
				SetPropertyInstance(elevation);
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
		/// The latitude of a location. For example <code>37.42242</code>.
		/// </summary>
		private Latitude_Core latitude;
		public Latitude_Core Latitude
		{
			get
			{
				return latitude;
			}
			set
			{
				latitude = value;
				SetPropertyInstance(latitude);
			}
		}

		/// <summary>
		/// The longitude of a location. For example <code>-122.08585</code>.
		/// </summary>
		private Longitude_Core longitude;
		public Longitude_Core Longitude
		{
			get
			{
				return longitude;
			}
			set
			{
				longitude = value;
				SetPropertyInstance(longitude);
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