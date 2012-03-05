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
	/// Specific qualifications required for this role.
	/// </summary>
	public class Qualifications_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 181;
			}
		}

		public string Id
		{
			get
			{
				return "qualifications";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Qualifications", typeof(Qualifications_Core));
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