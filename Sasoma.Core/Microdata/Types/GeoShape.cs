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
		private Box_Core box;
		public Box_Core Box
		{
			get
			{
				return box;
			}
			set
			{
				box = value;
				SetPropertyInstance(box);
			}
		}

		/// <summary>
		/// A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.
		/// </summary>
		private Circle_Core circle;
		public Circle_Core Circle
		{
			get
			{
				return circle;
			}
			set
			{
				circle = value;
				SetPropertyInstance(circle);
			}
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
		/// A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
		/// </summary>
		private Line_Core line;
		public Line_Core Line
		{
			get
			{
				return line;
			}
			set
			{
				line = value;
				SetPropertyInstance(line);
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
		/// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more spacedelimited points where the first and final points are identical.
		/// </summary>
		private Polygon_Core polygon;
		public Polygon_Core Polygon
		{
			get
			{
				return polygon;
			}
			set
			{
				polygon = value;
				SetPropertyInstance(polygon);
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