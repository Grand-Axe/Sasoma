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
	/// The rating given in this review. Note that reviews can themselves be rated. The <code>reviewRating</code> applies to rating given by the review. The <code>aggregateRating</code> property applies to the review itself, as a creative work.
	/// </summary>
	public class ReviewRating_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 198;
			}
		}

		public string Id
		{
			get
			{
				return "reviewRating";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ReviewRating", typeof(ReviewRating_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{229};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{222};
			}
		}

	}
}