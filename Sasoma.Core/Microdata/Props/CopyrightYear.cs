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
	/// The year during which the claimed copyright for the CreativeWork was first asserted.
	/// </summary>
	public class CopyrightYear_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 58;
			}
		}

		public string Id
		{
			get
			{
				return "copyrightYear";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "CopyrightYear", typeof(CopyrightYear_Core));
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
				return new int[]{5};
			}
		}

	}
}