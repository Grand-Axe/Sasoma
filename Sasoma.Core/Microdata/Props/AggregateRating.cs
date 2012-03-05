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
	/// The overall rating, based on a collection of reviews or ratings, of the item.
	/// </summary>
	public class AggregateRating_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 10;
			}
		}

		public string Id
		{
			get
			{
				return "aggregateRating";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "AggregateRating", typeof(AggregateRating_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{193,215,78,206,189};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{13};
			}
		}

	}
}