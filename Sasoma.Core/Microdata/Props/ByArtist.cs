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
	/// The artist that performed this album or recording.
	/// </summary>
	public class ByArtist_Core : PropertyCore
	{
		public ByArtist_Core()
		{
			this._PropertyId = 39;
			this._Id = "byArtist";
			string label = "";
			GetLabel(out label, "ByArtist", typeof(ByArtist_Core));
			this._Label = label;
			this._Domains = new int[]{174,178};
			this._Ranges = new int[]{176};
		}
	}
}