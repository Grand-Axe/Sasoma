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
	/// The season number.
	/// </summary>
	public class SeasonNumber_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 202;
			}
		}

		public string Id
		{
			get
			{
				return "seasonNumber";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "SeasonNumber", typeof(SeasonNumber_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{257};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{4};
			}
		}

	}
}