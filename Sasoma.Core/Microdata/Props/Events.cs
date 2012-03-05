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
	/// Upcoming or past events associated with this place or organization.
	/// </summary>
	public class Events_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 85;
			}
		}

		public string Id
		{
			get
			{
				return "events";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Events", typeof(Events_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{193,206};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{98};
			}
		}

	}
}