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
	/// Awards won by this person or for this creative work.
	/// </summary>
	public class Awards_Core : PropertyCore
	{
		public Awards_Core()
		{
			this._PropertyId = 26;
			this._Id = "awards";
			string label = "";
			GetLabel(out label, "Awards", typeof(Awards_Core));
			this._Label = label;
			this._Domains = new int[]{201,78};
			this._Ranges = new int[]{6};
		}
	}
}