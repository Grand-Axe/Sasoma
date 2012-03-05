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
	/// The job title of the person (for example, Financial Manager).
	/// </summary>
	public class JobTitle_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 125;
			}
		}

		public string Id
		{
			get
			{
				return "jobTitle";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "JobTitle", typeof(JobTitle_Core));
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
				return new int[]{6};
			}
		}

	}
}