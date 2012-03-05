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
	/// Publication date for the job posting.
	/// </summary>
	public class DatePosted_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 63;
			}
		}

		public string Id
		{
			get
			{
				return "datePosted";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "DatePosted", typeof(DatePosted_Core));
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
				return new int[]{2};
			}
		}

	}
}