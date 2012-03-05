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
	/// The main performer or performers of the event\u2014for example, a presenter, musician, or actor.
	/// </summary>
	public class Performers_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 158;
			}
		}

		public string Id
		{
			get
			{
				return "performers";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Performers", typeof(Performers_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{98};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{201,193};
			}
		}

	}
}