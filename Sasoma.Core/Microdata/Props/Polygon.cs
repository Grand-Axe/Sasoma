using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Microdata.Interfaces;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Types;

namespace Sasoma.Microdata.Properties
{
	/// <summary>
	/// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more spacedelimited points where the first and final points are identical.
	/// </summary>
	public class Polygon_Core : PropertyCore
	{
		public Polygon_Core()
		{
			this._PropertyId = 161;
			this._Id = "polygon";
			string label = "";
			GetLabel(out label, "Polygon", typeof(Polygon_Core));
			this._Label = label;
			this._Domains = new int[]{114};
			this._Ranges = new int[]{6};
		}
	}
}