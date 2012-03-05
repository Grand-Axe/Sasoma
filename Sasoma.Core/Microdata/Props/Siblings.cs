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
	/// A sibling of the person.
	/// </summary>
	public class Siblings_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 207;
			}
		}

		public string Id
		{
			get
			{
				return "siblings";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Siblings", typeof(Siblings_Core));
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