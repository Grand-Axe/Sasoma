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
	/// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
	/// </summary>
	public class HonorificPrefix_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 105;
			}
		}

		public string Id
		{
			get
			{
				return "honorificPrefix";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "HonorificPrefix", typeof(HonorificPrefix_Core));
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
				return new int[]{6};
			}
		}

	}
}