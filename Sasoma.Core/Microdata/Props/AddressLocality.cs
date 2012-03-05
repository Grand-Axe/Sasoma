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
	/// The locality. For example, Mountain View.
	/// </summary>
	public class AddressLocality_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 7;
			}
		}

		public string Id
		{
			get
			{
				return "addressLocality";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "AddressLocality", typeof(AddressLocality_Core));
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