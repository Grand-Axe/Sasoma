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
	/// Thumbnail image for an image or video.
	/// </summary>
	public class Thumbnail_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 197;
			}
		}

		public string Id
		{
			get
			{
				return "thumbnail";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Thumbnail", typeof(Thumbnail_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{285,136};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{136};
			}
		}

	}
}