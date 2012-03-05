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
	/// Organization offering the job position.
	/// </summary>
	public class HiringOrganization_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 103;
			}
		}

		public string Id
		{
			get
			{
				return "hiringOrganization";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "HiringOrganization", typeof(HiringOrganization_Core));
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
				return new int[]{193};
			}
		}

	}
}