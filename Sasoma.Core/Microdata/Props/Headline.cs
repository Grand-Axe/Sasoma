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
	/// Headline of the article
	/// </summary>
	public class Headline_Core : PropertyCore
	{
		public Headline_Core()
		{
			this._PropertyId = 100;
			this._Id = "headline";
			string label = "";
			GetLabel(out label, "Headline", typeof(Headline_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{6};
		}
	}
}