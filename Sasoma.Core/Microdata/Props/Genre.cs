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
	/// Genre of the creative work
	/// </summary>
	public class Genre_Core : PropertyCore
	{
		public Genre_Core()
		{
			this._PropertyId = 97;
			this._Id = "genre";
			string label = "";
			GetLabel(out label, "Genre", typeof(Genre_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{6};
		}
	}
}