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
	/// The illustrator of the book.
	/// </summary>
	public class Illustrator_Core : PropertyCore
	{
		public Illustrator_Core()
		{
			this._PropertyId = 107;
			this._Id = "illustrator";
			string label = "";
			GetLabel(out label, "Illustrator", typeof(Illustrator_Core));
			this._Label = label;
			this._Domains = new int[]{41};
			this._Ranges = new int[]{201};
		}
	}
}