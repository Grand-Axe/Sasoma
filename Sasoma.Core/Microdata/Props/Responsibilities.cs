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
	/// Responsibilities associated with this role.
	/// </summary>
	public class Responsibilities_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 193;
			}
		}

		public string Id
		{
			get
			{
				return "responsibilities";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Responsibilities", typeof(Responsibilities_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{144};
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