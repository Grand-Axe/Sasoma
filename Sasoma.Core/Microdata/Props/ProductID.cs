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
	/// The product identifier, such as ISBN. For example: <code>&lt;meta itemprop='productID' content='isbn:123-456-789'/&gt;</code>.
	/// </summary>
	public class ProductID_Core : PropertyCore
	{
		public ProductID_Core()
		{
			this._PropertyId = 175;
			this._Id = "productID";
			string label = "";
			GetLabel(out label, "ProductID", typeof(ProductID_Core));
			this._Label = label;
			this._Domains = new int[]{215};
			this._Ranges = new int[]{6};
		}
	}
}