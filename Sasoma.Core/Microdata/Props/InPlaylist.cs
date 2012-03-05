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
	/// The playlist to which this recording belongs.
	/// </summary>
	public class InPlaylist_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 111;
			}
		}

		public string Id
		{
			get
			{
				return "inPlaylist";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "InPlaylist", typeof(InPlaylist_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{178};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{177};
			}
		}

	}
}