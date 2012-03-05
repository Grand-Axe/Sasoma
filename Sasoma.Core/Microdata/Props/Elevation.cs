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
	/// The elevation of a location.
	/// </summary>
	public class Elevation_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 74;
			}
		}

		public string Id
		{
			get
			{
				return "elevation";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Elevation", typeof(Elevation_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{114,113};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{6,5};
			}
		}

	}
}