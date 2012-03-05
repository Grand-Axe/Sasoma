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
	/// The method of cooking, such as Frying, Steaming, ...
	/// </summary>
	public class CookingMethod_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 56;
			}
		}

		public string Id
		{
			get
			{
				return "cookingMethod";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "CookingMethod", typeof(CookingMethod_Core));
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
				return new int[]{6};
			}
		}

	}
}