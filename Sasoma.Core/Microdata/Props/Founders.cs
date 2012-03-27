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
	/// A person who founded this organization.
	/// </summary>
	public class Founders_Core : PropertyCore
	{
		public Founders_Core()
		{
			this._PropertyId = 94;
			this._Id = "founders";
			string label = "";
			GetLabel(out label, "Founders", typeof(Founders_Core));
			this._Label = label;
			this._Domains = new int[]{193};
			this._Ranges = new int[]{201};
		}
	}
}