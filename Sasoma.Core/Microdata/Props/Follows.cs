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
	/// The most generic uni-directional social relation.
	/// </summary>
	public class Follows_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 93;
			}
		}

		public string Id
		{
			get
			{
				return "follows";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Follows", typeof(Follows_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{201};
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