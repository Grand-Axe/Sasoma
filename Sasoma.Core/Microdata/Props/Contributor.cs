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
	/// A secondary contributor to the CreativeWork.
	/// </summary>
	public class Contributor_Core : PropertyCore
	{
		public Contributor_Core()
		{
			this._PropertyId = 54;
			this._Id = "contributor";
			string label = "";
			GetLabel(out label, "Contributor", typeof(Contributor_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{201,193};
		}
	}
}