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
	/// A contact location for a person's place of work.
	/// </summary>
	public class WorkLocation_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 237;
			}
		}

		public string Id
		{
			get
			{
				return "workLocation";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "WorkLocation", typeof(WorkLocation_Core));
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
				return new int[]{206,70};
			}
		}

	}
}