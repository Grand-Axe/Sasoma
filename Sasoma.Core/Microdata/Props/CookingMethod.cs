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
	/// The method of cooking, such as Frying, Steaming, ...
	/// </summary>
	public class CookingMethod_Core : PropertyCore
	{
		public CookingMethod_Core()
		{
			this._PropertyId = 56;
			this._Id = "cookingMethod";
			string label = "";
			GetLabel(out label, "CookingMethod", typeof(CookingMethod_Core));
			this._Label = label;
			this._Domains = new int[]{224};
			this._Ranges = new int[]{6};
		}
	}
}