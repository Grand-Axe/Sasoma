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
	/// Indicates whether this image is representative of the content of the page.
	/// </summary>
	public class RepresentativeOfPage_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 191;
			}
		}

		public string Id
		{
			get
			{
				return "representativeOfPage";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "RepresentativeOfPage", typeof(RepresentativeOfPage_Core));
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
				return new int[]{0};
			}
		}

	}
}