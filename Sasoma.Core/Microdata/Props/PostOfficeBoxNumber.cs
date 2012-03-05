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
	/// The post offce box number for PO box addresses.
	/// </summary>
	public class PostOfficeBoxNumber_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 162;
			}
		}

		public string Id
		{
			get
			{
				return "postOfficeBoxNumber";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PostOfficeBoxNumber", typeof(PostOfficeBoxNumber_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{213};
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