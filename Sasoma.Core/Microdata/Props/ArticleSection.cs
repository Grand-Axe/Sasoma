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
	/// Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
	/// </summary>
	public class ArticleSection_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 16;
			}
		}

		public string Id
		{
			get
			{
				return "articleSection";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ArticleSection", typeof(ArticleSection_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{20};
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