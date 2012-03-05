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
	/// The most generic bi-directional social/work relation.
	/// </summary>
	public class Knows_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 127;
			}
		}

		public string Id
		{
			get
			{
				return "knows";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Knows", typeof(Knows_Core));
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