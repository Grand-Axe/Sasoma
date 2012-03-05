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
	/// The item that is being reviewed/rated.
	/// </summary>
	public class ItemReviewed_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 123;
			}
		}

		public string Id
		{
			get
			{
				return "itemReviewed";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ItemReviewed", typeof(ItemReviewed_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{13,229};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{266};
			}
		}

	}
}