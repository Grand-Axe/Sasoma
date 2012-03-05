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
	/// The edition of the book.
	/// </summary>
	public class BookEdition_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 33;
			}
		}

		public string Id
		{
			get
			{
				return "bookEdition";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "BookEdition", typeof(BookEdition_Core));
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
				return new int[]{6};
			}
		}

	}
}