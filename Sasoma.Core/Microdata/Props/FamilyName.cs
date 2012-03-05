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
	/// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the Name property.
	/// </summary>
	public class FamilyName_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 89;
			}
		}

		public string Id
		{
			get
			{
				return "familyName";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "FamilyName", typeof(FamilyName_Core));
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