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
	/// Indicates whether this image is representative of the content of the page.
	/// </summary>
	public class RepresentativeOfPage_Core : PropertyCore
	{
		public RepresentativeOfPage_Core()
		{
			this._PropertyId = 191;
			this._Id = "representativeOfPage";
			string label = "";
			GetLabel(out label, "RepresentativeOfPage", typeof(RepresentativeOfPage_Core));
			this._Label = label;
			this._Domains = new int[]{136};
			this._Ranges = new int[]{0};
		}
	}
}