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
	/// The number of words in the text of the Article.
	/// </summary>
	public class WordCount_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 235;
			}
		}

		public string Id
		{
			get
			{
				return "wordCount";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "WordCount", typeof(WordCount_Core));
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
				return new int[]{4};
			}
		}

	}
}