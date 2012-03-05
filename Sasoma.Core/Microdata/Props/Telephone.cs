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
	/// The telephone number.
	/// </summary>
	public class Telephone_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 196;
			}
		}

		public string Id
		{
			get
			{
				return "telephone";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Telephone", typeof(Telephone_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{193,70,206,201};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{6};
			}
		}

	}
}