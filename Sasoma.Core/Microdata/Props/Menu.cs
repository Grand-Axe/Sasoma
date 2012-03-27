using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Microdata.Interfaces;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Types;

namespace Sasoma.Microdata.Properties
{
	/// <summary>
	/// Either the actual menu or a URL of the menu.
	/// </summary>
	public class Menu_Core : PropertyCore
	{
		public Menu_Core()
		{
			this._PropertyId = 139;
			this._Id = "menu";
			string label = "";
			GetLabel(out label, "Menu", typeof(Menu_Core));
			this._Label = label;
			this._Domains = new int[]{106};
			this._Ranges = new int[]{6,7};
		}
	}
}