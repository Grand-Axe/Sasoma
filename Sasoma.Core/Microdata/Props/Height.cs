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
	/// The height of the media object.
	/// </summary>
	public class Height_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 101;
			}
		}

		public string Id
		{
			get
			{
				return "height";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Height", typeof(Height_Core));
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
				return new int[]{76};
			}
		}

	}
}