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
	/// Nationality of the person.
	/// </summary>
	public class Nationality_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 144;
			}
		}

		public string Id
		{
			get
			{
				return "nationality";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Nationality", typeof(Nationality_Core));
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
				return new int[]{74};
			}
		}

	}
}