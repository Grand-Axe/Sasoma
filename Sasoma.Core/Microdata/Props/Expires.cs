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
	/// Date the content expires and is no longer useful or available. Useful for videos.
	/// </summary>
	public class Expires_Core : PropertyCore
	{
		public Expires_Core()
		{
			this._PropertyId = 88;
			this._Id = "expires";
			string label = "";
			GetLabel(out label, "Expires", typeof(Expires_Core));
			this._Label = label;
			this._Domains = new int[]{161};
			this._Ranges = new int[]{2};
		}
	}
}