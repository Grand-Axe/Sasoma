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
	/// The person's spouse.
	/// </summary>
	public class Spouse_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 213;
			}
		}

		public string Id
		{
			get
			{
				return "spouse";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Spouse", typeof(Spouse_Core));
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
				return new int[]{201};
			}
		}

	}
}