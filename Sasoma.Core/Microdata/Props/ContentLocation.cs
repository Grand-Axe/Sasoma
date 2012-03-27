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
	/// The location of the content.
	/// </summary>
	public class ContentLocation_Core : PropertyCore
	{
		public ContentLocation_Core()
		{
			this._PropertyId = 50;
			this._Id = "contentLocation";
			string label = "";
			GetLabel(out label, "ContentLocation", typeof(ContentLocation_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{206};
		}
	}
}