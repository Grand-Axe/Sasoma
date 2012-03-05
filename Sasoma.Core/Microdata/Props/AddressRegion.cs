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
	/// The region. For example, CA.
	/// </summary>
	public class AddressRegion_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 8;
			}
		}

		public string Id
		{
			get
			{
				return "addressRegion";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "AddressRegion", typeof(AddressRegion_Core));
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