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
	/// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
	/// </summary>
	public class WorstRating_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 239;
			}
		}

		public string Id
		{
			get
			{
				return "worstRating";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "WorstRating", typeof(WorstRating_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{222};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{5,6};
			}
		}

	}
}