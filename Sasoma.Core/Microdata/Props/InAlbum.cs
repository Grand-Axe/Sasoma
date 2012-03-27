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
	/// The album to which this recording belongs.
	/// </summary>
	public class InAlbum_Core : PropertyCore
	{
		public InAlbum_Core()
		{
			this._PropertyId = 109;
			this._Id = "inAlbum";
			string label = "";
			GetLabel(out label, "InAlbum", typeof(InAlbum_Core));
			this._Label = label;
			this._Domains = new int[]{178};
			this._Ranges = new int[]{174};
		}
	}
}