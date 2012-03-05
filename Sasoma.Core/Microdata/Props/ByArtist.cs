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
	/// The artist that performed this album or recording.
	/// </summary>
	public class ByArtist_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 39;
			}
		}

		public string Id
		{
			get
			{
				return "byArtist";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ByArtist", typeof(ByArtist_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{174,178};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{176};
			}
		}

	}
}