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
	/// The number of offers for the product.
	/// </summary>
	public class OfferCount_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 150;
			}
		}

		public string Id
		{
			get
			{
				return "offerCount";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "OfferCount", typeof(OfferCount_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{12};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{4};
			}
		}

	}
}