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
	/// A cast member of the movie, TV series, season, or episode, or video.
	/// </summary>
	public class Actors_Core : PropertyCore
	{
		public Actors_Core()
		{
			this._PropertyId = 3;
			this._Id = "actors";
			string label = "";
			GetLabel(out label, "Actors", typeof(Actors_Core));
			this._Label = label;
			this._Domains = new int[]{256,169,258};
			this._Ranges = new int[]{201};
		}
	}
}