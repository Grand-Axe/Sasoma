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
	/// The most generic bi-directional social/work relation.
	/// </summary>
	public class Knows_Core : PropertyCore
	{
		public Knows_Core()
		{
			this._PropertyId = 127;
			this._Id = "knows";
			string label = "";
			GetLabel(out label, "Knows", typeof(Knows_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{201};
		}
	}
}