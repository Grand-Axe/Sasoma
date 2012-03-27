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
	/// The year during which the claimed copyright for the CreativeWork was first asserted.
	/// </summary>
	public class CopyrightYear_Core : PropertyCore
	{
		public CopyrightYear_Core()
		{
			this._PropertyId = 58;
			this._Id = "copyrightYear";
			string label = "";
			GetLabel(out label, "CopyrightYear", typeof(CopyrightYear_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{5};
		}
	}
}