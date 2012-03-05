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
	/// The number of grams of saturated fat.
	/// </summary>
	public class SaturatedFatContent_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 201;
			}
		}

		public string Id
		{
			get
			{
				return "saturatedFatContent";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "SaturatedFatContent", typeof(SaturatedFatContent_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{187};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{159};
			}
		}

	}
}