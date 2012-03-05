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
	/// The bitrate of the media object.
	/// </summary>
	public class Bitrate_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 31;
			}
		}

		public string Id
		{
			get
			{
				return "bitrate";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Bitrate", typeof(Bitrate_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{161};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{6};
			}
		}

	}
}