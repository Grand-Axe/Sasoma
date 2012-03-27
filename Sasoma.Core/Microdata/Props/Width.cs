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
	/// The width of the media object.
	/// </summary>
	public class Width_Core : PropertyCore
	{
		public Width_Core()
		{
			this._PropertyId = 234;
			this._Id = "width";
			string label = "";
			GetLabel(out label, "Width", typeof(Width_Core));
			this._Label = label;
			this._Domains = new int[]{161};
			this._Ranges = new int[]{76};
		}
	}
}