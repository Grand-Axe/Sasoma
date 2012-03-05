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
	/// Date of death.
	/// </summary>
	public class DeathDate_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 66;
			}
		}

		public string Id
		{
			get
			{
				return "deathDate";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "DeathDate", typeof(DeathDate_Core));
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
				return new int[]{2};
			}
		}

	}
}