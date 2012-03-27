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
	/// The season number.
	/// </summary>
	public class SeasonNumber_Core : PropertyCore
	{
		public SeasonNumber_Core()
		{
			this._PropertyId = 202;
			this._Id = "seasonNumber";
			string label = "";
			GetLabel(out label, "SeasonNumber", typeof(SeasonNumber_Core));
			this._Label = label;
			this._Domains = new int[]{257};
			this._Ranges = new int[]{4};
		}
	}
}