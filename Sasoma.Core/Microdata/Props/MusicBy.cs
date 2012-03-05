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
	/// The composer of the movie or TV soundtrack.
	/// </summary>
	public class MusicBy_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 141;
			}
		}

		public string Id
		{
			get
			{
				return "musicBy";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "MusicBy", typeof(MusicBy_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{256,169,258};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{201,176};
			}
		}

	}
}