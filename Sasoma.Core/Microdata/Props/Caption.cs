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
	/// The caption for this object.
	/// </summary>
	public class Caption_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 41;
			}
		}

		public string Id
		{
			get
			{
				return "caption";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Caption", typeof(Caption_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{285,136};
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