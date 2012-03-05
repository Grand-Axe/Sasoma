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
	/// The production company or studio that made the movie, TV series, season, or episode, or video.
	/// </summary>
	public class ProductionCompany_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 176;
			}
		}

		public string Id
		{
			get
			{
				return "productionCompany";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ProductionCompany", typeof(ProductionCompany_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{256,169,285,258};
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