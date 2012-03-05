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
	/// The author of this content. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangabely.
	/// </summary>
	public class Author_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 24;
			}
		}

		public string Id
		{
			get
			{
				return "author";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Author", typeof(Author_Core));
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
				return new int[]{201,193};
			}
		}

	}
}