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
	/// A URL pointing to a player for a specific video. In general, this is the information in the <code>src</code> element of an <code>embed</code> tag and should not be the same as the content of the <code>loc</code> tag.
	/// </summary>
	public class EmbedURL_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 76;
			}
		}

		public string Id
		{
			get
			{
				return "embedURL";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "EmbedURL", typeof(EmbedURL_Core));
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
				return new int[]{7};
			}
		}

	}
}