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
	/// The album to which this recording belongs.
	/// </summary>
	public class InAlbum_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 109;
			}
		}

		public string Id
		{
			get
			{
				return "inAlbum";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "InAlbum", typeof(InAlbum_Core));
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
				return new int[]{174};
			}
		}

	}
}