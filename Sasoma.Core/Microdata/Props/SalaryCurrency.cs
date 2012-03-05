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
	/// The currency (coded using ISO 4217, http://en.wikipedia.org/wiki/ISO_4217 used for the main salary information in this job posting.
	/// </summary>
	public class SalaryCurrency_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 200;
			}
		}

		public string Id
		{
			get
			{
				return "salaryCurrency";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "SalaryCurrency", typeof(SalaryCurrency_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{144};
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