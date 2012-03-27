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
	/// The URL at which a reply may be posted to the specified UserComment.
	/// </summary>
	public class ReplyToURL_Core : PropertyCore
	{
		public ReplyToURL_Core()
		{
			this._PropertyId = 190;
			this._Id = "replyToUrl";
			string label = "";
			GetLabel(out label, "ReplyToURL", typeof(ReplyToURL_Core));
			this._Label = label;
			this._Domains = new int[]{275};
			this._Ranges = new int[]{7};
		}
	}
}