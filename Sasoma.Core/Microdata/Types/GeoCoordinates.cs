using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Interfaces;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Types
{
	/// <summary>
	/// The geographic coordinates of a place or event.
	/// </summary>
	public class GeoCoordinates_Core : TypeCore, IStructuredValue
	{
		public int TypeId
		{
			get
			{
				return 113;
			}
		}

		public string Id
		{
			get
			{
				return "GeoCoordinates";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/GeoCoordinates";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "GeoCoordinates", typeof(GeoCoordinates_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{266,138,253};
			}
		}

		public int[] SubTypes
		{
			get
			{
				return new int[0];
			}
		}

		public int[] SuperTypes
		{
			get
			{
				return new int[]{253};
			}
		}

		public int[] Properties
		{
			get
			{
				return new int[]{67,108,143,229,74,128,131};
			}
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