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
	/// The seasons of the TV series.
	/// </summary>
	public class Seasons_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 203;
			}
		}

		public string Id
		{
			get
			{
				return "seasons";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Seasons", typeof(Seasons_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{258};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{257};
			}
		}

	}
}