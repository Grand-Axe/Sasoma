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
	/// The number of calories
	/// </summary>
	public class Calories_Core : PropertyCore
	{
		public Calories_Core()
		{
			this._PropertyId = 40;
			this._Id = "calories";
			string label = "";
			GetLabel(out label, "Calories", typeof(Calories_Core));
			this._Label = label;
			this._Domains = new int[]{187};
			this._Ranges = new int[]{95};
		}
	}
}