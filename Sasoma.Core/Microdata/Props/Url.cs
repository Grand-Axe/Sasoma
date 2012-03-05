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
	/// URL of the item.
	/// </summary>
	public class URL_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 229;
			}
		}

		public string Id
		{
			get
			{
				return "url";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "URL", typeof(URL_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{266};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{7};
			}
		}

	}
}