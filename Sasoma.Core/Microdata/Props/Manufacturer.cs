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
	/// The manufacturer of the product.
	/// </summary>
	public class Manufacturer_Core : PropertyCore
	{
		public Manufacturer_Core()
		{
			this._PropertyId = 134;
			this._Id = "manufacturer";
			string label = "";
			GetLabel(out label, "Manufacturer", typeof(Manufacturer_Core));
			this._Label = label;
			this._Domains = new int[]{215};
			this._Ranges = new int[]{193};
		}
	}
}