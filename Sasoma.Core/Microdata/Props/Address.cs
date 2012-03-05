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
	/// Physical address of the item.
	/// </summary>
	public class Address_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 5;
			}
		}

		public string Id
		{
			get
			{
				return "address";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Address", typeof(Address_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{193,206,201};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{213};
			}
		}

	}
}