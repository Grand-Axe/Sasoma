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
	/// The date on which the CreativeWork was created.
	/// </summary>
	public class DateCreated_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 61;
			}
		}

		public string Id
		{
			get
			{
				return "dateCreated";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "DateCreated", typeof(DateCreated_Core));
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