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
	/// The location where the NewsArticle was produced.
	/// </summary>
	public class Dateline_Core : PropertyCore
	{
		public Dateline_Core()
		{
			this._PropertyId = 65;
			this._Id = "dateline";
			string label = "";
			GetLabel(out label, "Dateline", typeof(Dateline_Core));
			this._Label = label;
			this._Domains = new int[]{184};
			this._Ranges = new int[]{6};
		}
	}
}