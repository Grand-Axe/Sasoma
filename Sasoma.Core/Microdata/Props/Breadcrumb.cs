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
	/// A set of links that can help a user understand and navigate a website hierarchy.
	/// </summary>
	public class Breadcrumb_Core : PropertyCore
	{
		public Breadcrumb_Core()
		{
			this._PropertyId = 38;
			this._Id = "breadcrumb";
			string label = "";
			GetLabel(out label, "Breadcrumb", typeof(Breadcrumb_Core));
			this._Label = label;
			this._Domains = new int[]{293};
			this._Ranges = new int[]{6};
		}
	}
}