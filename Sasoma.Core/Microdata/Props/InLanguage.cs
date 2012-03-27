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
	/// The language of the content. please use one of the language codes from the <a href=\http://tools.ietf.org/html/bcp47\>IETF BCP 47 standard.</a>
	/// </summary>
	public class InLanguage_Core : PropertyCore
	{
		public InLanguage_Core()
		{
			this._PropertyId = 110;
			this._Id = "inLanguage";
			string label = "";
			GetLabel(out label, "InLanguage", typeof(InLanguage_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{6};
		}
	}
}