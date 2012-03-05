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
	/// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in <a href=\http://en.wikipedia.org/wiki/ISO_3166\ target=\new\>ISO 3166 format</a>.
	/// </summary>
	public class RegionsAllowed_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 188;
			}
		}

		public string Id
		{
			get
			{
				return "regionsAllowed";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "RegionsAllowed", typeof(RegionsAllowed_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{161};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{206};
			}
		}

	}
}