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
	/// The number of grams of fiber.
	/// </summary>
	public class FiberContent_Core : PropertyCore
	{
		public FiberContent_Core()
		{
			this._PropertyId = 92;
			this._Id = "fiberContent";
			string label = "";
			GetLabel(out label, "FiberContent", typeof(FiberContent_Core));
			this._Label = label;
			this._Domains = new int[]{187};
			this._Ranges = new int[]{159};
		}
	}
}