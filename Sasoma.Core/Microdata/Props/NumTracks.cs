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
	/// The number of tracks in this album or playlist.
	/// </summary>
	public class NumTracks_Core : PropertyCore
	{
		public NumTracks_Core()
		{
			this._PropertyId = 145;
			this._Id = "numTracks";
			string label = "";
			GetLabel(out label, "NumTracks", typeof(NumTracks_Core));
			this._Label = label;
			this._Domains = new int[]{177};
			this._Ranges = new int[]{4};
		}
	}
}