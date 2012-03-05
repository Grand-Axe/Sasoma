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
	/// The number of grams of trans fat.
	/// </summary>
	public class TransFatContent_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 225;
			}
		}

		public string Id
		{
			get
			{
				return "transFatContent";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "TransFatContent", typeof(TransFatContent_Core));
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