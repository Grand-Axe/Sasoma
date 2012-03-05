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
	/// The date on which the CreativeWork was most recently modified.
	/// </summary>
	public class DateModified_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 62;
			}
		}

		public string Id
		{
			get
			{
				return "dateModified";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "DateModified", typeof(DateModified_Core));
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