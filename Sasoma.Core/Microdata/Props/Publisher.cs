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
	/// The publisher of the creative work.
	/// </summary>
	public class Publisher_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 179;
			}
		}

		public string Id
		{
			get
			{
				return "publisher";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Publisher", typeof(Publisher_Core));
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
				return new int[]{193};
			}
		}

	}
}