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
	/// The number of calories
	/// </summary>
	public class Calories_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 40;
			}
		}

		public string Id
		{
			get
			{
				return "calories";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Calories", typeof(Calories_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{187};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{95};
			}
		}

	}
}