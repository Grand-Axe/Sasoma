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
	/// Indicates the collection or gallery to which the item belongs.
	/// </summary>
	public class IsPartOf_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 117;
			}
		}

		public string Id
		{
			get
			{
				return "isPartOf";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "IsPartOf", typeof(IsPartOf_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{293};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{64};
			}
		}

	}
}