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
	/// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the Name property.
	/// </summary>
	public class GivenName_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 99;
			}
		}

		public string Id
		{
			get
			{
				return "givenName";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "GivenName", typeof(GivenName_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{201};
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