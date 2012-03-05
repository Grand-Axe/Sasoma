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
	/// The count of total number of ratings.
	/// </summary>
	public class RatingCount_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 182;
			}
		}

		public string Id
		{
			get
			{
				return "ratingCount";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "RatingCount", typeof(RatingCount_Core));
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