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
	/// A person who founded this organization.
	/// </summary>
	public class Founders_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 94;
			}
		}

		public string Id
		{
			get
			{
				return "founders";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Founders", typeof(Founders_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{193};
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