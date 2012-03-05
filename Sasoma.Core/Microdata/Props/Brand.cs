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
	/// The brand of the product.
	/// </summary>
	public class Brand_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 37;
			}
		}

		public string Id
		{
			get
			{
				return "brand";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Brand", typeof(Brand_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{215};
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