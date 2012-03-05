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
	/// A member of this organization.
	/// </summary>
	public class Members_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 137;
			}
		}

		public string Id
		{
			get
			{
				return "members";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Members", typeof(Members_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{193};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{201,193};
			}
		}

	}
}