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
	/// File size in (mega/kilo) bytes.
	/// </summary>
	public class ContentSize_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 52;
			}
		}

		public string Id
		{
			get
			{
				return "contentSize";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ContentSize", typeof(ContentSize_Core));
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
				return new int[]{6};
			}
		}

	}
}