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
	/// A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.
	/// </summary>
	public class Circle_Core : PropertyCore
	{
		public Circle_Core()
		{
			this._PropertyId = 45;
			this._Id = "circle";
			string label = "";
			GetLabel(out label, "Circle", typeof(Circle_Core));
			this._Label = label;
			this._Domains = new int[]{114};
			this._Ranges = new int[]{6};
		}
	}
}