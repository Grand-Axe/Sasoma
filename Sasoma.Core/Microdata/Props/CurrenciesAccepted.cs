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
	/// The currency accepted (in <a href=\http://en.wikipedia.org/wiki/ISO_4217\ target=\new\>ISO 4217 currency format</a>).
	/// </summary>
	public class CurrenciesAccepted_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 60;
			}
		}

		public string Id
		{
			get
			{
				return "currenciesAccepted";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "CurrenciesAccepted", typeof(CurrenciesAccepted_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{155};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{6};
			}
		}

	}
}