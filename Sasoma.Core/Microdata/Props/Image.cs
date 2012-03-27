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
	/// URL of an image of the item.
	/// </summary>
	public class Image_Core : PropertyCore
	{
		public Image_Core()
		{
			this._PropertyId = 108;
			this._Id = "image";
			string label = "";
			GetLabel(out label, "Image", typeof(Image_Core));
			this._Label = label;
			this._Domains = new int[]{266};
			this._Ranges = new int[]{7};
		}
	}
}