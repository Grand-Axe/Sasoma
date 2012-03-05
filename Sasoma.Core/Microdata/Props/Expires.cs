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
	/// Date the content expires and is no longer useful or available. Useful for videos.
	/// </summary>
	public class Expires_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 88;
			}
		}

		public string Id
		{
			get
			{
				return "expires";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Expires", typeof(Expires_Core));
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
				return new int[]{2};
			}
		}

	}
}