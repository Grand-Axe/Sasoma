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
	/// Indicates if this web page element is the main subject of the page.
	/// </summary>
	public class MainContentOfPage_Core : PropertyCore
	{
		public MainContentOfPage_Core()
		{
			this._PropertyId = 133;
			this._Id = "mainContentOfPage";
			string label = "";
			GetLabel(out label, "MainContentOfPage", typeof(MainContentOfPage_Core));
			this._Label = label;
			this._Domains = new int[]{293};
			this._Ranges = new int[]{294};
		}
	}
}