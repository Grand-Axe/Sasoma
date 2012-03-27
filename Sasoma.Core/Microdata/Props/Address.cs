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
	/// Physical address of the item.
	/// </summary>
	public class Address_Core : PropertyCore
	{
		public Address_Core()
		{
			this._PropertyId = 5;
			this._Id = "address";
			string label = "";
			GetLabel(out label, "Address", typeof(Address_Core));
			this._Label = label;
			this._Domains = new int[]{193,206,201};
			this._Ranges = new int[]{213};
		}
	}
}