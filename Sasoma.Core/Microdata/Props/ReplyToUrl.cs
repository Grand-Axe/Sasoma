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
	/// The URL at which a reply may be posted to the specified UserComment.
	/// </summary>
	public class ReplyToURL_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 190;
			}
		}

		public string Id
		{
			get
			{
				return "replyToUrl";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ReplyToURL", typeof(ReplyToURL_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{275};
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