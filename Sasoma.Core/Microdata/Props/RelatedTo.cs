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
	/// The most generic familial relation.
	/// </summary>
	public class RelatedTo_Core : PropertyCore
	{
		public RelatedTo_Core()
		{
			this._PropertyId = 189;
			this._Id = "relatedTo";
			string label = "";
			GetLabel(out label, "RelatedTo", typeof(RelatedTo_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{201};
		}
	}
}