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
	/// The total time it takes to prepare and cook the recipe, in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 duration format</a>.
	/// </summary>
	public class TotalTime_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 222;
			}
		}

		public string Id
		{
			get
			{
				return "totalTime";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "TotalTime", typeof(TotalTime_Core));
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