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
	/// The cuisine of the restaurant.
	/// </summary>
	public class ServesCuisine_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 205;
			}
		}

		public string Id
		{
			get
			{
				return "servesCuisine";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ServesCuisine", typeof(ServesCuisine_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{106};
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