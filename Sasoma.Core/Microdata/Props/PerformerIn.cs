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
	/// Event that this person is a performer or participant in.
	/// </summary>
	public class PerformerIn_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 157;
			}
		}

		public string Id
		{
			get
			{
				return "performerIn";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PerformerIn", typeof(PerformerIn_Core));
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
				return new int[]{98};
			}
		}

	}
}