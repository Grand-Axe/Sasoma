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
	/// The TV series to which this episode or season belongs.
	/// </summary>
	public class PartOfTVSeries_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 155;
			}
		}

		public string Id
		{
			get
			{
				return "partOfTVSeries";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PartOfTVSeries", typeof(PartOfTVSeries_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{256,257};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{258};
			}
		}

	}
}