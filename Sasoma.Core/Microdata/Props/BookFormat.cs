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
	/// The format of the book.
	/// </summary>
	public class BookFormat_Core : PropertyCore
	{
		public BookFormat_Core()
		{
			this._PropertyId = 34;
			this._Id = "bookFormat";
			string label = "";
			GetLabel(out label, "BookFormat", typeof(BookFormat_Core));
			this._Label = label;
			this._Domains = new int[]{41};
			this._Ranges = new int[]{42};
		}
	}
}