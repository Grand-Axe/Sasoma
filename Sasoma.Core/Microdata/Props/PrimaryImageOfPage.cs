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
	/// Indicates the main image on the page
	/// </summary>
	public class PrimaryImageOfPage_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 169;
			}
		}

		public string Id
		{
			get
			{
				return "primaryImageOfPage";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PrimaryImageOfPage", typeof(PrimaryImageOfPage_Core));
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
				return new int[]{136};
			}
		}

	}
}