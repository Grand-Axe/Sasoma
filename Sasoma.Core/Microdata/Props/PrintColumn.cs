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
	/// The number of the column in which the NewsArticle appears in the print edition.
	/// </summary>
	public class PrintColumn_Core : PropertyCore
	{
		public PrintColumn_Core()
		{
			this._PropertyId = 170;
			this._Id = "printColumn";
			string label = "";
			GetLabel(out label, "PrintColumn", typeof(PrintColumn_Core));
			this._Label = label;
			this._Domains = new int[]{184};
			this._Ranges = new int[]{6};
		}
	}
}