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
	/// Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes textual label and formal code, with the property repeated for each applicable value.
	/// </summary>
	public class OccupationalCategory_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 149;
			}
		}

		public string Id
		{
			get
			{
				return "occupationalCategory";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "OccupationalCategory", typeof(OccupationalCategory_Core));
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