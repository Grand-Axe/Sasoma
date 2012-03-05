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
	/// A colleague of the person.
	/// </summary>
	public class Colleagues_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 46;
			}
		}

		public string Id
		{
			get
			{
				return "colleagues";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Colleagues", typeof(Colleagues_Core));
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