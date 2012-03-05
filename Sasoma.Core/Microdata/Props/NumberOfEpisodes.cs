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
	/// The number of episodes in this season or series.
	/// </summary>
	public class NumberOfEpisodes_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 146;
			}
		}

		public string Id
		{
			get
			{
				return "numberOfEpisodes";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "NumberOfEpisodes", typeof(NumberOfEpisodes_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{257,258};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{5};
			}
		}

	}
}