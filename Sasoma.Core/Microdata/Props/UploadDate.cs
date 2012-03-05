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
	/// Date when this media object was uploaded to this site.
	/// </summary>
	public class UploadDate_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 228;
			}
		}

		public string Id
		{
			get
			{
				return "uploadDate";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "UploadDate", typeof(UploadDate_Core));
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