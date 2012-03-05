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
	/// The serving size, in terms of the number of volume or mass
	/// </summary>
	public class ServingSize_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 206;
			}
		}

		public string Id
		{
			get
			{
				return "servingSize";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ServingSize", typeof(ServingSize_Core));
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
				return new int[]{6};
			}
		}

	}
}