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
	/// The edition of the print product in which the NewsArticle appears.
	/// </summary>
	public class PrintEdition_Core : PropertyCore
	{
		public PrintEdition_Core()
		{
			this._PropertyId = 171;
			this._Id = "printEdition";
			string label = "";
			GetLabel(out label, "PrintEdition", typeof(PrintEdition_Core));
			this._Label = label;
			this._Domains = new int[]{184};
			this._Ranges = new int[]{6};
		}
	}
}