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
	/// The location where the NewsArticle was produced.
	/// </summary>
	public class Dateline_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 65;
			}
		}

		public string Id
		{
			get
			{
				return "dateline";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Dateline", typeof(Dateline_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{184};
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