using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Interfaces;

namespace Sasoma.Microdata.Properties
{
	/// <summary>
	/// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more spacedelimited points where the first and final points are identical.
	/// </summary>
	public class Polygon_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 161;
			}
		}

		public string Id
		{
			get
			{
				return "polygon";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Polygon", typeof(Polygon_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{114};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{6};
			}
		}

	}
}