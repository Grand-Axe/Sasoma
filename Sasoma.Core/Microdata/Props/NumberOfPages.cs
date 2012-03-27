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
	/// The number of pages in the book.
	/// </summary>
	public class NumberOfPages_Core : PropertyCore
	{
		public NumberOfPages_Core()
		{
			this._PropertyId = 147;
			this._Id = "numberOfPages";
			string label = "";
			GetLabel(out label, "NumberOfPages", typeof(NumberOfPages_Core));
			this._Label = label;
			this._Domains = new int[]{41};
			this._Ranges = new int[]{4};
		}
	}
}