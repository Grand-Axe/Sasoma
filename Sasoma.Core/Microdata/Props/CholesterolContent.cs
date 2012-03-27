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
	/// The number of milligrams of cholesterol.
	/// </summary>
	public class CholesterolContent_Core : PropertyCore
	{
		public CholesterolContent_Core()
		{
			this._PropertyId = 44;
			this._Id = "cholesterolContent";
			string label = "";
			GetLabel(out label, "CholesterolContent", typeof(CholesterolContent_Core));
			this._Label = label;
			this._Domains = new int[]{187};
			this._Ranges = new int[]{159};
		}
	}
}