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
	public class Box_Core : PropertyCore
	{
		public Box_Core()
		{
			this._PropertyId = 35;
			this._Id = "box";
			string label = "";
			GetLabel(out label, "Box", typeof(Box_Core));
			this._Label = label;
			this._Domains = new int[]{114};
			this._Ranges = new int[]{6};
		}
	}
}