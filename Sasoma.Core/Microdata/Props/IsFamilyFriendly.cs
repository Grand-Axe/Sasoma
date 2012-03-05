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
	/// Indicates whether this content is family friendly.
	/// </summary>
	public class IsFamilyFriendly_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 116;
			}
		}

		public string Id
		{
			get
			{
				return "isFamilyFriendly";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "IsFamilyFriendly", typeof(IsFamilyFriendly_Core));
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
				return new int[]{0};
			}
		}

	}
}