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
	/// Responsibilities associated with this role.
	/// </summary>
	public class Responsibilities_Core : PropertyCore
	{
		public Responsibilities_Core()
		{
			this._PropertyId = 193;
			this._Id = "responsibilities";
			string label = "";
			GetLabel(out label, "Responsibilities", typeof(Responsibilities_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{6};
		}
	}
}