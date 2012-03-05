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
	/// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
	/// </summary>
	public class Affiliation_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 9;
			}
		}

		public string Id
		{
			get
			{
				return "affiliation";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Affiliation", typeof(Affiliation_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{201};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{193};
			}
		}

	}
}