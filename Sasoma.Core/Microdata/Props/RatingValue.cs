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
	/// The rating for the content.
	/// </summary>
	public class RatingValue_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 183;
			}
		}

		public string Id
		{
			get
			{
				return "ratingValue";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "RatingValue", typeof(RatingValue_Core));
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
				return new int[]{6};
			}
		}

	}
}