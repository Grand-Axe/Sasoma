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
	/// The media objects that encode this creative work
	/// </summary>
	public class Encodings_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 81;
			}
		}

		public string Id
		{
			get
			{
				return "encodings";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Encodings", typeof(Encodings_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{78};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{161};
			}
		}

	}
}