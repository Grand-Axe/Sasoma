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
	/// The ISBN of the book.
	/// </summary>
	public class ISBN_Core : PropertyCore
	{
		public ISBN_Core()
		{
			this._PropertyId = 118;
			this._Id = "isbn";
			string label = "";
			GetLabel(out label, "ISBN", typeof(ISBN_Core));
			this._Label = label;
			this._Domains = new int[]{41};
			this._Ranges = new int[]{6};
		}
	}
}