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
	/// File size in (mega/kilo) bytes.
	/// </summary>
	public class ContentSize_Core : PropertyCore
	{
		public ContentSize_Core()
		{
			this._PropertyId = 52;
			this._Id = "contentSize";
			string label = "";
			GetLabel(out label, "ContentSize", typeof(ContentSize_Core));
			this._Label = label;
			this._Domains = new int[]{161};
			this._Ranges = new int[]{6};
		}
	}
}