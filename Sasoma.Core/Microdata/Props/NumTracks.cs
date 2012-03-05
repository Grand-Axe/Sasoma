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
	/// The number of tracks in this album or playlist.
	/// </summary>
	public class NumTracks_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 145;
			}
		}

		public string Id
		{
			get
			{
				return "numTracks";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "NumTracks", typeof(NumTracks_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{177};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{4};
			}
		}

	}
}