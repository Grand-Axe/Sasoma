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
	/// Official rating of a piece of content\u2014for example,'MPAA PG-13'.
	/// </summary>
	public class ContentRating_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 51;
			}
		}

		public string Id
		{
			get
			{
				return "contentRating";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ContentRating", typeof(ContentRating_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{78};
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