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
	/// The number of grams of trans fat.
	/// </summary>
	public class TransFatContent_Core : PropertyCore
	{
		public TransFatContent_Core()
		{
			this._PropertyId = 225;
			this._Id = "transFatContent";
			string label = "";
			GetLabel(out label, "TransFatContent", typeof(TransFatContent_Core));
			this._Label = label;
			this._Domains = new int[]{187};
			this._Ranges = new int[]{159};
		}
	}
}