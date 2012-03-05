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
	/// The count of total number of reviews.
	/// </summary>
	public class ReviewCount_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 195;
			}
		}

		public string Id
		{
			get
			{
				return "reviewCount";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ReviewCount", typeof(ReviewCount_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{13};
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