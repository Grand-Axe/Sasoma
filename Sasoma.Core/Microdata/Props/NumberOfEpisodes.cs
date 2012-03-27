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
	/// The number of episodes in this season or series.
	/// </summary>
	public class NumberOfEpisodes_Core : PropertyCore
	{
		public NumberOfEpisodes_Core()
		{
			this._PropertyId = 146;
			this._Id = "numberOfEpisodes";
			string label = "";
			GetLabel(out label, "NumberOfEpisodes", typeof(NumberOfEpisodes_Core));
			this._Label = label;
			this._Domains = new int[]{257,258};
			this._Ranges = new int[]{5};
		}
	}
}