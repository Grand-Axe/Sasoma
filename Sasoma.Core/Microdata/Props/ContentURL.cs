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
	/// Actual bytes of the media object, for example the image file or video file.
	/// </summary>
	public class ContentURL_Core : PropertyCore
	{
		public ContentURL_Core()
		{
			this._PropertyId = 53;
			this._Id = "contentURL";
			string label = "";
			GetLabel(out label, "ContentURL", typeof(ContentURL_Core));
			this._Label = label;
			this._Domains = new int[]{161};
			this._Ranges = new int[]{7};
		}
	}
}