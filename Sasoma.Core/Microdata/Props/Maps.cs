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
	/// A URL to a map of the place.
	/// </summary>
	public class Maps_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 135;
			}
		}

		public string Id
		{
			get
			{
				return "maps";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Maps", typeof(Maps_Core));
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
				return new int[]{7};
			}
		}

	}
}