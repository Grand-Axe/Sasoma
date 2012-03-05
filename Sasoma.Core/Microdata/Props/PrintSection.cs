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
	/// If this NewsArticle appears in print, this field indicates the print section in which the article appeared.
	/// </summary>
	public class PrintSection_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 173;
			}
		}

		public string Id
		{
			get
			{
				return "printSection";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PrintSection", typeof(PrintSection_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{184};
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