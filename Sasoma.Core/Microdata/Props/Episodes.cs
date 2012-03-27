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
	/// The episode of a TV series or season.
	/// </summary>
	public class Episodes_Core : PropertyCore
	{
		public Episodes_Core()
		{
			this._PropertyId = 84;
			this._Id = "episodes";
			string label = "";
			GetLabel(out label, "Episodes", typeof(Episodes_Core));
			this._Label = label;
			this._Domains = new int[]{257,258};
			this._Ranges = new int[]{256};
		}
	}
}