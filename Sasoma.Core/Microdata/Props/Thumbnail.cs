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
	/// Thumbnail image for an image or video.
	/// </summary>
	public class Thumbnail_Core : PropertyCore
	{
		public Thumbnail_Core()
		{
			this._PropertyId = 197;
			this._Id = "thumbnail";
			string label = "";
			GetLabel(out label, "Thumbnail", typeof(Thumbnail_Core));
			this._Label = label;
			this._Domains = new int[]{285,136};
			this._Ranges = new int[]{136};
		}
	}
}