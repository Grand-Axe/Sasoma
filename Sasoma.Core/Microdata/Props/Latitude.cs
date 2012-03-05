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
	/// The latitude of a location. For example <code>37.42242</code>.
	/// </summary>
	public class Latitude_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 128;
			}
		}

		public string Id
		{
			get
			{
				return "latitude";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Latitude", typeof(Latitude_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{113};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{5,6};
			}
		}

	}
}