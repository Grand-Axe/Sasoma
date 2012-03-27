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
	/// The industry associated with the job position.
	/// </summary>
	public class Industry_Core : PropertyCore
	{
		public Industry_Core()
		{
			this._PropertyId = 113;
			this._Id = "industry";
			string label = "";
			GetLabel(out label, "Industry", typeof(Industry_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{6};
		}
	}
}