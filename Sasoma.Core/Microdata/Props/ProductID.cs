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
	/// The product identifier, such as ISBN. For example: <code>&lt;meta itemprop='productID' content='isbn:123-456-789'/&gt;</code>.
	/// </summary>
	public class ProductID_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 175;
			}
		}

		public string Id
		{
			get
			{
				return "productID";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ProductID", typeof(ProductID_Core));
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
				return new int[]{6};
			}
		}

	}
}