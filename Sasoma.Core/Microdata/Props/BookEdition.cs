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
	/// The edition of the book.
	/// </summary>
	public class BookEdition_Core : PropertyCore
	{
		public BookEdition_Core()
		{
			this._PropertyId = 33;
			this._Id = "bookEdition";
			string label = "";
			GetLabel(out label, "BookEdition", typeof(BookEdition_Core));
			this._Label = label;
			this._Domains = new int[]{41};
			this._Ranges = new int[]{6};
		}
	}
}