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
	/// An organization to which the person belongs.
	/// </summary>
	public class MemberOf_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 136;
			}
		}

		public string Id
		{
			get
			{
				return "memberOf";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "MemberOf", typeof(MemberOf_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{201};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{193};
			}
		}

	}
}