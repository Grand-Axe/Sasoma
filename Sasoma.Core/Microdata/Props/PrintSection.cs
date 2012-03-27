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
	/// If this NewsArticle appears in print, this field indicates the print section in which the article appeared.
	/// </summary>
	public class PrintSection_Core : PropertyCore
	{
		public PrintSection_Core()
		{
			this._PropertyId = 173;
			this._Id = "printSection";
			string label = "";
			GetLabel(out label, "PrintSection", typeof(PrintSection_Core));
			this._Label = label;
			this._Domains = new int[]{184};
			this._Ranges = new int[]{6};
		}
	}
}