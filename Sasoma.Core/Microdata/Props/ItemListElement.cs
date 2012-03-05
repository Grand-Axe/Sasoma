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
	/// A single list item.
	/// </summary>
	public class ItemListElement_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 120;
			}
		}

		public string Id
		{
			get
			{
				return "itemListElement";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ItemListElement", typeof(ItemListElement_Core));
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