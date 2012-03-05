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
	/// A (typically single) geographic location associated with the job position.
	/// </summary>
	public class JobLocation_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 124;
			}
		}

		public string Id
		{
			get
			{
				return "jobLocation";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "JobLocation", typeof(JobLocation_Core));
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
				return new int[]{206};
			}
		}

	}
}