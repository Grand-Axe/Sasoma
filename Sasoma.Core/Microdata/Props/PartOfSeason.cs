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
	/// The season to which this episode belongs.
	/// </summary>
	public class PartOfSeason_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 154;
			}
		}

		public string Id
		{
			get
			{
				return "partOfSeason";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PartOfSeason", typeof(PartOfSeason_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{256};
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