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
	/// Photographs of this place.
	/// </summary>
	public class Photos_Core : PropertyCore
	{
		public Photos_Core()
		{
			this._PropertyId = 159;
			this._Id = "photos";
			string label = "";
			GetLabel(out label, "Photos", typeof(Photos_Core));
			this._Label = label;
			this._Domains = new int[]{206};
			this._Ranges = new int[]{204,136};
		}
	}
}