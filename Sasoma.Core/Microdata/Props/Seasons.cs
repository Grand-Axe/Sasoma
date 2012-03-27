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
	/// The seasons of the TV series.
	/// </summary>
	public class Seasons_Core : PropertyCore
	{
		public Seasons_Core()
		{
			this._PropertyId = 203;
			this._Id = "seasons";
			string label = "";
			GetLabel(out label, "Seasons", typeof(Seasons_Core));
			this._Label = label;
			this._Domains = new int[]{258};
			this._Ranges = new int[]{257};
		}
	}
}