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
	/// A URL pointing to a player for a specific video. In general, this is the information in the <code>src</code> element of an <code>embed</code> tag and should not be the same as the content of the <code>loc</code> tag.
	/// </summary>
	public class EmbedURL_Core : PropertyCore
	{
		public EmbedURL_Core()
		{
			this._PropertyId = 76;
			this._Id = "embedURL";
			string label = "";
			GetLabel(out label, "EmbedURL", typeof(EmbedURL_Core));
			this._Label = label;
			this._Domains = new int[]{161};
			this._Ranges = new int[]{7};
		}
	}
}