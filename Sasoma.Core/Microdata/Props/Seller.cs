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
	/// The seller of the product.
	/// </summary>
	public class Seller_Core : PropertyCore
	{
		public Seller_Core()
		{
			this._PropertyId = 204;
			this._Id = "seller";
			string label = "";
			GetLabel(out label, "Seller", typeof(Seller_Core));
			this._Label = label;
			this._Domains = new int[]{189};
			this._Ranges = new int[]{193};
		}
	}
}