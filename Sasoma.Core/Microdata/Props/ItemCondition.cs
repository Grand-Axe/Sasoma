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
	/// The condition of the item for sale\u2014for example New, Refurbished, Used, etc.
	/// </summary>
	public class ItemCondition_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 119;
			}
		}

		public string Id
		{
			get
			{
				return "itemCondition";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ItemCondition", typeof(ItemCondition_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{189};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{190};
			}
		}

	}
}