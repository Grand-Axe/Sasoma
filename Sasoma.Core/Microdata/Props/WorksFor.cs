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
	/// Organizations that the person works for.
	/// </summary>
	public class WorksFor_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 238;
			}
		}

		public string Id
		{
			get
			{
				return "worksFor";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "WorksFor", typeof(WorksFor_Core));
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
				return new int[]{193};
			}
		}

	}
}