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
	/// The region. For example, CA.
	/// </summary>
	public class AddressRegion_Core : PropertyCore
	{
		public AddressRegion_Core()
		{
			this._PropertyId = 8;
			this._Id = "addressRegion";
			string label = "";
			GetLabel(out label, "AddressRegion", typeof(AddressRegion_Core));
			this._Label = label;
			this._Domains = new int[]{213};
			this._Ranges = new int[]{6};
		}
	}
}