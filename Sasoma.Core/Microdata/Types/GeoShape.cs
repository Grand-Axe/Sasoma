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
	/// The geographic shape of a place.
	/// </summary>
	public class GeoShape_Core : TypeCore, IStructuredValue
	{
		public GeoShape_Core()
		{
			this._TypeId = 114;
			this._Id = "GeoShape";
			this._Schema_Org_Url = "http://schema.org/GeoShape";
			string label = "";
			GetLabel(out label, "GeoShape", typeof(GeoShape_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138,253};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{253};
			this._Properties = new int[]{67,108,143,229,35,45,74,129,161};

		}

		/// <summary>
		/// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more spacedelimited points where the first and final points are identical.
		/// </summary>
		public Box_Core Box { get; set; }

		/// <summary>
		/// A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.
		/// </summary>
		public Circle_Core Circle { get; set; }

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
		/// A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
		/// </summary>
		public Line_Core Line { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more spacedelimited points where the first and final points are identical.
		/// </summary>
		public Polygon_Core Polygon { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		public Properties.URL_Core URL { get; set; }

	}
}