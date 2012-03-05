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
	/// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
	/// </summary>
	public class WorkHours_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 236;
			}
		}

		public string Id
		{
			get
			{
				return "workHours";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "WorkHours", typeof(WorkHours_Core));
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