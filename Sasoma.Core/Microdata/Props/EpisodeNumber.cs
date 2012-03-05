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
	/// The episode number.
	/// </summary>
	public class EpisodeNumber_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 83;
			}
		}

		public string Id
		{
			get
			{
				return "episodeNumber";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "EpisodeNumber", typeof(EpisodeNumber_Core));
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
				return new int[]{5};
			}
		}

	}
}