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
	/// An offer to sell this item\u2014for example, an offer to sell a product, the DVD of a movie, or tickets to an event.
	/// </summary>
	public class Offers_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 151;
			}
		}

		public string Id
		{
			get
			{
				return "offers";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Offers", typeof(Offers_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{215,78,98};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{189};
			}
		}

	}
}