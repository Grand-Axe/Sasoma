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
	/// A thumbnail image relevant to the Thing.
	/// </summary>
	public class ThumbnailURL_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 219;
			}
		}

		public string Id
		{
			get
			{
				return "thumbnailUrl";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ThumbnailURL", typeof(ThumbnailURL_Core));
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
				return new int[]{7};
			}
		}

	}
}