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
	/// The availability of this item\u2014for example In stock, Out of stock, Pre-order, etc.
	/// </summary>
	public class Availability_Core : PropertyCore
	{
		public Availability_Core()
		{
			this._PropertyId = 25;
			this._Id = "availability";
			string label = "";
			GetLabel(out label, "Availability", typeof(Availability_Core));
			this._Label = label;
			this._Domains = new int[]{189};
			this._Ranges = new int[]{140};
		}
	}
}