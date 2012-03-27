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
	/// The playlist to which this recording belongs.
	/// </summary>
	public class InPlaylist_Core : PropertyCore
	{
		public InPlaylist_Core()
		{
			this._PropertyId = 111;
			this._Id = "inPlaylist";
			string label = "";
			GetLabel(out label, "InPlaylist", typeof(InPlaylist_Core));
			this._Label = label;
			this._Domains = new int[]{178};
			this._Ranges = new int[]{177};
		}
	}
}