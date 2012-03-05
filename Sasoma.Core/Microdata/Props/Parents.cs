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
	/// A parents of the person.
	/// </summary>
	public class Parents_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 153;
			}
		}

		public string Id
		{
			get
			{
				return "parents";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Parents", typeof(Parents_Core));
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