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
	/// A single list item.
	/// </summary>
	public class ItemListElement_Core : PropertyCore
	{
		public ItemListElement_Core()
		{
			this._PropertyId = 120;
			this._Id = "itemListElement";
			string label = "";
			GetLabel(out label, "ItemListElement", typeof(ItemListElement_Core));
			this._Label = label;
			this._Domains = new int[]{141};
			this._Ranges = new int[]{6};
		}
	}
}