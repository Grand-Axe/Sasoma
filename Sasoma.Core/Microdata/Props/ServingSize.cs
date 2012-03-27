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
	/// The serving size, in terms of the number of volume or mass
	/// </summary>
	public class ServingSize_Core : PropertyCore
	{
		public ServingSize_Core()
		{
			this._PropertyId = 206;
			this._Id = "servingSize";
			string label = "";
			GetLabel(out label, "ServingSize", typeof(ServingSize_Core));
			this._Label = label;
			this._Domains = new int[]{187};
			this._Ranges = new int[]{6};
		}
	}
}