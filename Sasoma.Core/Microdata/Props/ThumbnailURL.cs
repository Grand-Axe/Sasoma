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
	/// A thumbnail image relevant to the Thing.
	/// </summary>
	public class ThumbnailURL_Core : PropertyCore
	{
		public ThumbnailURL_Core()
		{
			this._PropertyId = 219;
			this._Id = "thumbnailUrl";
			string label = "";
			GetLabel(out label, "ThumbnailURL", typeof(ThumbnailURL_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{7};
		}
	}
}