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
	/// Headline of the article
	/// </summary>
	public class Headline_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 100;
			}
		}

		public string Id
		{
			get
			{
				return "headline";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Headline", typeof(Headline_Core));
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
				return new int[]{6};
			}
		}

	}
}