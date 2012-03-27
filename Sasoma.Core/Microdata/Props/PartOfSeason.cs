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
	/// The season to which this episode belongs.
	/// </summary>
	public class PartOfSeason_Core : PropertyCore
	{
		public PartOfSeason_Core()
		{
			this._PropertyId = 154;
			this._Id = "partOfSeason";
			string label = "";
			GetLabel(out label, "PartOfSeason", typeof(PartOfSeason_Core));
			this._Label = label;
			this._Domains = new int[]{256};
			this._Ranges = new int[]{257};
		}
	}
}