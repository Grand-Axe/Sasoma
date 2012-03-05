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
	/// A cast member of the movie, TV series, season, or episode, or video.
	/// </summary>
	public class Actors_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 3;
			}
		}

		public string Id
		{
			get
			{
				return "actors";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Actors", typeof(Actors_Core));
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
				return new int[]{201};
			}
		}

	}
}