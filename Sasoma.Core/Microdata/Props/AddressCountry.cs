using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Interfaces;

namespace Sasoma.Microdata.Properties
{
	/// <summary>
	/// The country. For example, USA. You can also provide the two-letter <a href=\http://en.wikipedia.org/wiki/ISO_3166-1\ target=\new\>ISO 3166-1 alpha-2 country code</a>.
	/// </summary>
	public class AddressCountry_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 6;
			}
		}

		public string Id
		{
			get
			{
				return "addressCountry";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "AddressCountry", typeof(AddressCountry_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{213};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{74};
			}
		}

	}
}