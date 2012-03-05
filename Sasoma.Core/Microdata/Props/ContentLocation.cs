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
	/// The location of the content.
	/// </summary>
	public class ContentLocation_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 50;
			}
		}

		public string Id
		{
			get
			{
				return "contentLocation";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ContentLocation", typeof(ContentLocation_Core));
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
				return new int[]{206};
			}
		}

	}
}