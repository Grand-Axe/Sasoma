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
	/// Indicates the main image on the page
	/// </summary>
	public class PrimaryImageOfPage_Core : PropertyCore
	{
		public PrimaryImageOfPage_Core()
		{
			this._PropertyId = 169;
			this._Id = "primaryImageOfPage";
			string label = "";
			GetLabel(out label, "PrimaryImageOfPage", typeof(PrimaryImageOfPage_Core));
			this._Label = label;
			this._Domains = new int[]{293};
			this._Ranges = new int[]{136};
		}
	}
}