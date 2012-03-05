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
	/// The producer of the movie, TV series, season, or episode, or video.
	/// </summary>
	public class Producer_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 174;
			}
		}

		public string Id
		{
			get
			{
				return "producer";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Producer", typeof(Producer_Core));
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