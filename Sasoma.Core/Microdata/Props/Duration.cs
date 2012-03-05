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
	/// The duration of the item (movie, audio recording, event, etc.) in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>.
	/// </summary>
	public class Duration_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 71;
			}
		}

		public string Id
		{
			get
			{
				return "duration";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Duration", typeof(Duration_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{169,161,178,98};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{86};
			}
		}

	}
}