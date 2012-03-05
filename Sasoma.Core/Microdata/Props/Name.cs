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
	/// The name of the item.
	/// </summary>
	public class Name_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 143;
			}
		}

		public string Id
		{
			get
			{
				return "name";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Name", typeof(Name_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{266};
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