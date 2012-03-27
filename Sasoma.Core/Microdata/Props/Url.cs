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
	/// URL of the item.
	/// </summary>
	public class URL_Core : PropertyCore
	{
		public URL_Core()
		{
			this._PropertyId = 229;
			this._Id = "url";
			string label = "";
			GetLabel(out label, "URL", typeof(URL_Core));
			this._Label = label;
			this._Domains = new int[]{266};
			this._Ranges = new int[]{7};
		}
	}
}