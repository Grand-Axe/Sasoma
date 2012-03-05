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
	/// A collection of music albums.
	/// </summary>
	public class Albums_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 11;
			}
		}

		public string Id
		{
			get
			{
				return "albums";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Albums", typeof(Albums_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{176};
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