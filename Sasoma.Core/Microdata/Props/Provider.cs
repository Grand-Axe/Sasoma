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
	/// Specifies the Person or Organization that distributed the CreativeWork.
	/// </summary>
	public class Provider_Core : PropertyCore
	{
		public Provider_Core()
		{
			this._PropertyId = 178;
			this._Id = "provider";
			string label = "";
			GetLabel(out label, "Provider", typeof(Provider_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{201,193};
		}
	}
}