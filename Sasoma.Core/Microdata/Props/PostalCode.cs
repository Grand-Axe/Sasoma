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
	/// The postal code. For example, 94043.
	/// </summary>
	public class PostalCode_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 163;
			}
		}

		public string Id
		{
			get
			{
				return "postalCode";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PostalCode", typeof(PostalCode_Core));
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