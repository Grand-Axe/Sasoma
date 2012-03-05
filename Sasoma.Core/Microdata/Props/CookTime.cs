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
	/// The time it takes to actually cook the dish, in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 duration format</a>.
	/// </summary>
	public class CookTime_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 55;
			}
		}

		public string Id
		{
			get
			{
				return "cookTime";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "CookTime", typeof(CookTime_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{224};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{86};
			}
		}

	}
}