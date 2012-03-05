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
	/// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
	/// </summary>
	public class BestRating_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 29;
			}
		}

		public string Id
		{
			get
			{
				return "bestRating";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "BestRating", typeof(BestRating_Core));
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