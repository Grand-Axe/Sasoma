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
	/// The seller of the product.
	/// </summary>
	public class Seller_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 204;
			}
		}

		public string Id
		{
			get
			{
				return "seller";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Seller", typeof(Seller_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{189};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{193};
			}
		}

	}
}