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
	/// An additional name for a Person, can be used for a middle name.
	/// </summary>
	public class AdditionalName_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 4;
			}
		}

		public string Id
		{
			get
			{
				return "additionalName";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "AdditionalName", typeof(AdditionalName_Core));
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