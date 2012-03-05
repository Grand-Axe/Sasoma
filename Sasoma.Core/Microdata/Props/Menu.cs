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
	/// Either the actual menu or a URL of the menu.
	/// </summary>
	public class Menu_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 139;
			}
		}

		public string Id
		{
			get
			{
				return "menu";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Menu", typeof(Menu_Core));
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
				return new int[]{6,7};
			}
		}

	}
}