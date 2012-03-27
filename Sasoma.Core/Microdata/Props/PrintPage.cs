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
	/// If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).
	/// </summary>
	public class PrintPage_Core : PropertyCore
	{
		public PrintPage_Core()
		{
			this._PropertyId = 172;
			this._Id = "printPage";
			string label = "";
			GetLabel(out label, "PrintPage", typeof(PrintPage_Core));
			this._Label = label;
			this._Domains = new int[]{184};
			this._Ranges = new int[]{6};
		}
	}
}