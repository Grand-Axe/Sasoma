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
	/// exif data for this object.
	/// </summary>
	public class ExifData_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 86;
			}
		}

		public string Id
		{
			get
			{
				return "exifData";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ExifData", typeof(ExifData_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{136};
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