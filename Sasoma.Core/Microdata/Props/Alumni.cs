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
	/// Alumni of educational organization.
	/// </summary>
	public class Alumni_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 13;
			}
		}

		public string Id
		{
			get
			{
				return "alumni";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Alumni", typeof(Alumni_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{88};
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