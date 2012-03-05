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
	/// Review of the item.
	/// </summary>
	public class Reviews_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 199;
			}
		}

		public string Id
		{
			get
			{
				return "reviews";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Reviews", typeof(Reviews_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{193,215,78,206,189};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{229};
			}
		}

	}
}