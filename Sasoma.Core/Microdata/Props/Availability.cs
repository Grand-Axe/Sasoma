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
	/// The availability of this item\u2014for example In stock, Out of stock, Pre-order, etc.
	/// </summary>
	public class Availability_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 25;
			}
		}

		public string Id
		{
			get
			{
				return "availability";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Availability", typeof(Availability_Core));
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
				return new int[]{140};
			}
		}

	}
}