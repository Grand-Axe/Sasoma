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
	/// People working for this organization.
	/// </summary>
	public class Employees_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 77;
			}
		}

		public string Id
		{
			get
			{
				return "employees";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Employees", typeof(Employees_Core));
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
				return new int[]{201};
			}
		}

	}
}