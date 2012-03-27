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
	/// Date when this media object was uploaded to this site.
	/// </summary>
	public class UploadDate_Core : PropertyCore
	{
		public UploadDate_Core()
		{
			this._PropertyId = 228;
			this._Id = "uploadDate";
			string label = "";
			GetLabel(out label, "UploadDate", typeof(UploadDate_Core));
			this._Label = label;
			this._Domains = new int[]{161};
			this._Ranges = new int[]{2};
		}
	}
}