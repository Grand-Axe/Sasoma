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
	/// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
	/// </summary>
	public class EmploymentType_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 78;
			}
		}

		public string Id
		{
			get
			{
				return "employmentType";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "EmploymentType", typeof(EmploymentType_Core));
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