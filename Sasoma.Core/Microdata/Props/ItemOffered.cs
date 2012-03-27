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
	/// The item being sold.
	/// </summary>
	public class ItemOffered_Core : PropertyCore
	{
		public ItemOffered_Core()
		{
			this._PropertyId = 122;
			this._Id = "itemOffered";
			string label = "";
			GetLabel(out label, "ItemOffered", typeof(ItemOffered_Core));
			this._Label = label;
			this._Domains = new int[]{189};
			this._Ranges = new int[]{215};
		}
	}
}