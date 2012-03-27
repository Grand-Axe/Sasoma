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
	/// A music recording (track)\u2014usually a single song.
	/// </summary>
	public class Tracks_Core : PropertyCore
	{
		public Tracks_Core()
		{
			this._PropertyId = 223;
			this._Id = "tracks";
			string label = "";
			GetLabel(out label, "Tracks", typeof(Tracks_Core));
			this._Label = label;
			this._Domains = new int[]{177,176};
			this._Ranges = new int[]{178};
		}
	}
}