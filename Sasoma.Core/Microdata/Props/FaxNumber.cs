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
	/// The fax number.
	/// </summary>
	public class FaxNumber_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 91;
			}
		}

		public string Id
		{
			get
			{
				return "faxNumber";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "FaxNumber", typeof(FaxNumber_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{193,70,206,201};
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