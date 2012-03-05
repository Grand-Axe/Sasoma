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
	/// Skills required to fulfill this role.
	/// </summary>
	public class Skills_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 209;
			}
		}

		public string Id
		{
			get
			{
				return "skills";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Skills", typeof(Skills_Core));
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