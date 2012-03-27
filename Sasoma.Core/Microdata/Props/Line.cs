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
	/// A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
	/// </summary>
	public class Line_Core : PropertyCore
	{
		public Line_Core()
		{
			this._PropertyId = 129;
			this._Id = "line";
			string label = "";
			GetLabel(out label, "Line", typeof(Line_Core));
			this._Label = label;
			this._Domains = new int[]{114};
			this._Ranges = new int[]{6};
		}
	}
}