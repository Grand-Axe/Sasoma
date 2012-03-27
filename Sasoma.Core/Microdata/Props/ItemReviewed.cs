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
	/// The item that is being reviewed/rated.
	/// </summary>
	public class ItemReviewed_Core : PropertyCore
	{
		public ItemReviewed_Core()
		{
			this._PropertyId = 123;
			this._Id = "itemReviewed";
			string label = "";
			GetLabel(out label, "ItemReviewed", typeof(ItemReviewed_Core));
			this._Label = label;
			this._Domains = new int[]{13,229};
			this._Ranges = new int[]{266};
		}
	}
}