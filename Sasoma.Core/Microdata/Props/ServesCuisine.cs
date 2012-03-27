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
	/// The cuisine of the restaurant.
	/// </summary>
	public class ServesCuisine_Core : PropertyCore
	{
		public ServesCuisine_Core()
		{
			this._PropertyId = 205;
			this._Id = "servesCuisine";
			string label = "";
			GetLabel(out label, "ServesCuisine", typeof(ServesCuisine_Core));
			this._Label = label;
			this._Domains = new int[]{106};
			this._Ranges = new int[]{6};
		}
	}
}