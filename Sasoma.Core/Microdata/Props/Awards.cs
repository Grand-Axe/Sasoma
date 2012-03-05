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
	/// Awards won by this person or for this creative work.
	/// </summary>
	public class Awards_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 26;
			}
		}

		public string Id
		{
			get
			{
				return "awards";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Awards", typeof(Awards_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{201,78};
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