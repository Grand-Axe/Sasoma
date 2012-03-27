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
	/// The number of grams of protein.
	/// </summary>
	public class ProteinContent_Core : PropertyCore
	{
		public ProteinContent_Core()
		{
			this._PropertyId = 177;
			this._Id = "proteinContent";
			string label = "";
			GetLabel(out label, "ProteinContent", typeof(ProteinContent_Core));
			this._Label = label;
			this._Domains = new int[]{187};
			this._Ranges = new int[]{159};
		}
	}
}