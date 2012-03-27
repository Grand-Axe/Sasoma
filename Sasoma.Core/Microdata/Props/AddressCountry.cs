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
	/// The country. For example, USA. You can also provide the two-letter <a href=\http://en.wikipedia.org/wiki/ISO_3166-1\ target=\new\>ISO 3166-1 alpha-2 country code</a>.
	/// </summary>
	public class AddressCountry_Core : PropertyCore
	{
		public AddressCountry_Core()
		{
			this._PropertyId = 6;
			this._Id = "addressCountry";
			string label = "";
			GetLabel(out label, "AddressCountry", typeof(AddressCountry_Core));
			this._Label = label;
			this._Domains = new int[]{213};
			this._Ranges = new int[]{74};
		}
	}
}