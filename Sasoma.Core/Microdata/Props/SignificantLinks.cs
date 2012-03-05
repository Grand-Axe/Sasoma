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
	/// The most significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most
	/// </summary>
	public class SignificantLinks_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 208;
			}
		}

		public string Id
		{
			get
			{
				return "significantLinks";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "SignificantLinks", typeof(SignificantLinks_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{293};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{7};
			}
		}

	}
}