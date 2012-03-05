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
	/// A person attending the event.
	/// </summary>
	public class Attendees_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 19;
			}
		}

		public string Id
		{
			get
			{
				return "attendees";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Attendees", typeof(Attendees_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{98};
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