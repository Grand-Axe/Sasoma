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
	/// A music recording (track)\u2014usually a single song.
	/// </summary>
	public class Tracks_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 223;
			}
		}

		public string Id
		{
			get
			{
				return "tracks";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Tracks", typeof(Tracks_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{177,176};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{178};
			}
		}

	}
}