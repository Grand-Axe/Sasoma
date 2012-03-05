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
	/// The geo coordinates of the place.
	/// </summary>
	public class Geo_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 98;
			}
		}

		public string Id
		{
			get
			{
				return "geo";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Geo", typeof(Geo_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{206};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{113,114};
			}
		}

	}
}