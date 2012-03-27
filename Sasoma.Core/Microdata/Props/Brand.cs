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
	/// The brand of the product.
	/// </summary>
	public class Brand_Core : PropertyCore
	{
		public Brand_Core()
		{
			this._PropertyId = 37;
			this._Id = "brand";
			string label = "";
			GetLabel(out label, "Brand", typeof(Brand_Core));
			this._Label = label;
			this._Domains = new int[]{215};
			this._Ranges = new int[]{193};
		}
	}
}