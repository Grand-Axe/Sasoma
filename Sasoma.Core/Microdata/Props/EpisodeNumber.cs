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
	/// The episode number.
	/// </summary>
	public class EpisodeNumber_Core : PropertyCore
	{
		public EpisodeNumber_Core()
		{
			this._PropertyId = 83;
			this._Id = "episodeNumber";
			string label = "";
			GetLabel(out label, "EpisodeNumber", typeof(EpisodeNumber_Core));
			this._Label = label;
			this._Domains = new int[]{256};
			this._Ranges = new int[]{5};
		}
	}
}