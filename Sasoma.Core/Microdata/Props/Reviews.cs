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
	/// Review of the item.
	/// </summary>
	public class Reviews_Core : PropertyCore
	{
		public Reviews_Core()
		{
			this._PropertyId = 199;
			this._Id = "reviews";
			string label = "";
			GetLabel(out label, "Reviews", typeof(Reviews_Core));
			this._Label = label;
			this._Domains = new int[]{193,215,78,206,189};
			this._Ranges = new int[]{229};
		}
	}
}