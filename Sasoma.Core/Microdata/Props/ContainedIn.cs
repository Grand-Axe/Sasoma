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
	/// The basic containment relation between places.
	/// </summary>
	public class ContainedIn_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 49;
			}
		}

		public string Id
		{
			get
			{
				return "containedIn";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ContainedIn", typeof(ContainedIn_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{206};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{206};
			}
		}

	}
}