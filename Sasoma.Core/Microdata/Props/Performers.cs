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
	/// The main performer or performers of the event\u2014for example, a presenter, musician, or actor.
	/// </summary>
	public class Performers_Core : PropertyCore
	{
		public Performers_Core()
		{
			this._PropertyId = 158;
			this._Id = "performers";
			string label = "";
			GetLabel(out label, "Performers", typeof(Performers_Core));
			this._Label = label;
			this._Domains = new int[]{98};
			this._Ranges = new int[]{201,193};
		}
	}
}