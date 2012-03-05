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
	/// Actual bytes of the media object, for example the image file or video file.
	/// </summary>
	public class ContentURL_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 53;
			}
		}

		public string Id
		{
			get
			{
				return "contentURL";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ContentURL", typeof(ContentURL_Core));
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