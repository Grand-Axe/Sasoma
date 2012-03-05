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
	/// mp3, mpeg4, etc.
	/// </summary>
	public class EncodingFormat_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 80;
			}
		}

		public string Id
		{
			get
			{
				return "encodingFormat";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "EncodingFormat", typeof(EncodingFormat_Core));
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