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
	/// exif data for this object.
	/// </summary>
	public class ExifData_Core : PropertyCore
	{
		public ExifData_Core()
		{
			this._PropertyId = 86;
			this._Id = "exifData";
			string label = "";
			GetLabel(out label, "ExifData", typeof(ExifData_Core));
			this._Label = label;
			this._Domains = new int[]{136};
			this._Ranges = new int[]{6};
		}
	}
}