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
	/// Genre of the creative work
	/// </summary>
	public class Genre_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 97;
			}
		}

		public string Id
		{
			get
			{
				return "genre";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Genre", typeof(Genre_Core));
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