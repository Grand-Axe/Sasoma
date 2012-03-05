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
	/// The street address. For example, 1600 Amphitheatre Pkwy.
	/// </summary>
	public class StreetAddress_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 215;
			}
		}

		public string Id
		{
			get
			{
				return "streetAddress";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "StreetAddress", typeof(StreetAddress_Core));
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
				return new int[]{6};
			}
		}

	}
}