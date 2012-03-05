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
	/// The end date and time of the event (in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>).
	/// </summary>
	public class EndDate_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 82;
			}
		}

		public string Id
		{
			get
			{
				return "endDate";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "EndDate", typeof(EndDate_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{257,98,258};
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