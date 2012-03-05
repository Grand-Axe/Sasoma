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
	/// The price range of the business, for example <code>$$$</code>.
	/// </summary>
	public class PriceRange_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 167;
			}
		}

		public string Id
		{
			get
			{
				return "priceRange";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PriceRange", typeof(PriceRange_Core));
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