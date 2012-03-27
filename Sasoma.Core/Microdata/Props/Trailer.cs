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
	/// The trailer of the movie or TV series, season, or episode.
	/// </summary>
	public class Trailer_Core : PropertyCore
	{
		public Trailer_Core()
		{
			this._PropertyId = 224;
			this._Id = "trailer";
			string label = "";
			GetLabel(out label, "Trailer", typeof(Trailer_Core));
			this._Label = label;
			this._Domains = new int[]{256,169,258,257};
			this._Ranges = new int[]{285};
		}
	}
}