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
	/// The manufacturer of the product.
	/// </summary>
	public class Manufacturer_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 134;
			}
		}

		public string Id
		{
			get
			{
				return "manufacturer";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Manufacturer", typeof(Manufacturer_Core));
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