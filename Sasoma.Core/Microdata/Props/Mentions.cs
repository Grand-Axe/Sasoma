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
	/// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
	/// </summary>
	public class Mentions_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 138;
			}
		}

		public string Id
		{
			get
			{
				return "mentions";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Mentions", typeof(Mentions_Core));
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
				return new int[]{266};
			}
		}

	}
}