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
	/// Type of ordering (e.g. Ascending, Descending, Unordered).
	/// </summary>
	public class ItemListOrder_Core : PropertyCore
	{
		public ItemListOrder_Core()
		{
			this._PropertyId = 121;
			this._Id = "itemListOrder";
			string label = "";
			GetLabel(out label, "ItemListOrder", typeof(ItemListOrder_Core));
			this._Label = label;
			this._Domains = new int[]{141};
			this._Ranges = new int[]{6};
		}
	}
}