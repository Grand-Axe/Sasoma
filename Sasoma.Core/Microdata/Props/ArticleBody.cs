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
	/// The actual body of the article.
	/// </summary>
	public class ArticleBody_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 15;
			}
		}

		public string Id
		{
			get
			{
				return "articleBody";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ArticleBody", typeof(ArticleBody_Core));
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