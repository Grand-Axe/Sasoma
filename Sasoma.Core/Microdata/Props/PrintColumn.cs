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
	/// The number of the column in which the NewsArticle appears in the print edition.
	/// </summary>
	public class PrintColumn_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 170;
			}
		}

		public string Id
		{
			get
			{
				return "printColumn";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PrintColumn", typeof(PrintColumn_Core));
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