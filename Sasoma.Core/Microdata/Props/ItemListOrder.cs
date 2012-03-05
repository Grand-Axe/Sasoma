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
	/// Type of ordering (e.g. Ascending, Descending, Unordered).
	/// </summary>
	public class ItemListOrder_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 121;
			}
		}

		public string Id
		{
			get
			{
				return "itemListOrder";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ItemListOrder", typeof(ItemListOrder_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{141};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{6};
			}
		}

	}
}