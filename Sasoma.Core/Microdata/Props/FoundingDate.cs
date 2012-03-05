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
	/// The date that this organization was founded.
	/// </summary>
	public class FoundingDate_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 95;
			}
		}

		public string Id
		{
			get
			{
				return "foundingDate";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "FoundingDate", typeof(FoundingDate_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{193};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{2};
			}
		}

	}
}