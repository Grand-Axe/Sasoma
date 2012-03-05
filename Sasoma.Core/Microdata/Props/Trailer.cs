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
	/// The trailer of the movie or TV series, season, or episode.
	/// </summary>
	public class Trailer_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 224;
			}
		}

		public string Id
		{
			get
			{
				return "trailer";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Trailer", typeof(Trailer_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{256,169,258,257};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{285};
			}
		}

	}
}