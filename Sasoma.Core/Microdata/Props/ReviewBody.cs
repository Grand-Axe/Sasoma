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
	/// The actual body of the review
	/// </summary>
	public class ReviewBody_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 194;
			}
		}

		public string Id
		{
			get
			{
				return "reviewBody";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ReviewBody", typeof(ReviewBody_Core));
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
				return new int[]{6};
			}
		}

	}
}