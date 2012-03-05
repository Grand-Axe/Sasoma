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
	/// The longitude of a location. For example <code>-122.08585</code>.
	/// </summary>
	public class Longitude_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 131;
			}
		}

		public string Id
		{
			get
			{
				return "longitude";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Longitude", typeof(Longitude_Core));
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