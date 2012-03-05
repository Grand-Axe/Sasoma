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
	/// The location of the event or organization.
	/// </summary>
	public class Location_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 130;
			}
		}

		public string Id
		{
			get
			{
				return "location";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Location", typeof(Location_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{193,98};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{213,206};
			}
		}

	}
}