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
	/// The condition of the item for sale\u2014for example New, Refurbished, Used, etc.
	/// </summary>
	public class ItemCondition_Core : PropertyCore
	{
		public ItemCondition_Core()
		{
			this._PropertyId = 119;
			this._Id = "itemCondition";
			string label = "";
			GetLabel(out label, "ItemCondition", typeof(ItemCondition_Core));
			this._Label = label;
			this._Domains = new int[]{189};
			this._Ranges = new int[]{190};
		}
	}
}