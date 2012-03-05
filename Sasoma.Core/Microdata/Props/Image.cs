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
	/// URL of an image of the item.
	/// </summary>
	public class Image_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 108;
			}
		}

		public string Id
		{
			get
			{
				return "image";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Image", typeof(Image_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{266};
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