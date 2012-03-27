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
	/// The locality. For example, Mountain View.
	/// </summary>
	public class AddressLocality_Core : PropertyCore
	{
		public AddressLocality_Core()
		{
			this._PropertyId = 7;
			this._Id = "addressLocality";
			string label = "";
			GetLabel(out label, "AddressLocality", typeof(AddressLocality_Core));
			this._Label = label;
			this._Domains = new int[]{213};
			this._Ranges = new int[]{6};
		}
	}
}