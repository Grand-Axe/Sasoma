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
	/// The base salary of the job.
	/// </summary>
	public class BaseSalary_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 27;
			}
		}

		public string Id
		{
			get
			{
				return "baseSalary";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "BaseSalary", typeof(BaseSalary_Core));
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
				return new int[]{5};
			}
		}

	}
}