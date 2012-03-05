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
	/// The edition of the print product in which the NewsArticle appears.
	/// </summary>
	public class PrintEdition_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 171;
			}
		}

		public string Id
		{
			get
			{
				return "printEdition";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PrintEdition", typeof(PrintEdition_Core));
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