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
	/// Date of first broadcast/publication.
	/// </summary>
	public class DatePublished_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 64;
			}
		}

		public string Id
		{
			get
			{
				return "datePublished";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "DatePublished", typeof(DatePublished_Core));
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
				return new int[]{2};
			}
		}

	}
}