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
	/// The director of the movie, TV episode, or series.
	/// </summary>
	public class Director_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 68;
			}
		}

		public string Id
		{
			get
			{
				return "director";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Director", typeof(Director_Core));
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