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
	/// If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).
	/// </summary>
	public class PrintPage_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 172;
			}
		}

		public string Id
		{
			get
			{
				return "printPage";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PrintPage", typeof(PrintPage_Core));
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