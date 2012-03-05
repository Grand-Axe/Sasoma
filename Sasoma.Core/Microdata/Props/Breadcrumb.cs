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
	/// A set of links that can help a user understand and navigate a website hierarchy.
	/// </summary>
	public class Breadcrumb_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 38;
			}
		}

		public string Id
		{
			get
			{
				return "breadcrumb";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Breadcrumb", typeof(Breadcrumb_Core));
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
				return new int[]{6};
			}
		}

	}
}