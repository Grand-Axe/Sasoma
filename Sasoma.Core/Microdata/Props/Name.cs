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
	/// The name of the item.
	/// </summary>
	public class Name_Core : PropertyCore
	{
		public Name_Core()
		{
			this._PropertyId = 143;
			this._Id = "name";
			string label = "";
			GetLabel(out label, "Name", typeof(Name_Core));
			this._Label = label;
			this._Domains = new int[]{266};
			this._Ranges = new int[]{6};
		}
	}
}