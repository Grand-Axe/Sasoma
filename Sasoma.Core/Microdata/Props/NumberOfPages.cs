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
	/// The number of pages in the book.
	/// </summary>
	public class NumberOfPages_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 147;
			}
		}

		public string Id
		{
			get
			{
				return "numberOfPages";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "NumberOfPages", typeof(NumberOfPages_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{41};
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