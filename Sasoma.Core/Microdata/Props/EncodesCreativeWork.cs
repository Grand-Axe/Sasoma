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
	/// The creative work encoded by this media object
	/// </summary>
	public class EncodesCreativeWork_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 79;
			}
		}

		public string Id
		{
			get
			{
				return "encodesCreativeWork";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "EncodesCreativeWork", typeof(EncodesCreativeWork_Core));
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
				return new int[]{78};
			}
		}

	}
}