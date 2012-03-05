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
	/// Photographs of this place.
	/// </summary>
	public class Photos_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 159;
			}
		}

		public string Id
		{
			get
			{
				return "photos";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Photos", typeof(Photos_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{206};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{204,136};
			}
		}

	}
}