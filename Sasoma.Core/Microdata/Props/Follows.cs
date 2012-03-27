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
	/// The most generic uni-directional social relation.
	/// </summary>
	public class Follows_Core : PropertyCore
	{
		public Follows_Core()
		{
			this._PropertyId = 93;
			this._Id = "follows";
			string label = "";
			GetLabel(out label, "Follows", typeof(Follows_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{201};
		}
	}
}