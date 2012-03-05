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
	/// An embedded video object.
	/// </summary>
	public class Video_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 231;
			}
		}

		public string Id
		{
			get
			{
				return "video";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Video", typeof(Video_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{78};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{285};
			}
		}

	}
}