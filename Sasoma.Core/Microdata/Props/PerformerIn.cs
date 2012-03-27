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
	/// Event that this person is a performer or participant in.
	/// </summary>
	public class PerformerIn_Core : PropertyCore
	{
		public PerformerIn_Core()
		{
			this._PropertyId = 157;
			this._Id = "performerIn";
			string label = "";
			GetLabel(out label, "PerformerIn", typeof(PerformerIn_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{98};
		}
	}
}