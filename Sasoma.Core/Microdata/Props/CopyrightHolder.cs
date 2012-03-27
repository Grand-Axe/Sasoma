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
	/// The party holding the legal copyright to the CreativeWork.
	/// </summary>
	public class CopyrightHolder_Core : PropertyCore
	{
		public CopyrightHolder_Core()
		{
			this._PropertyId = 57;
			this._Id = "copyrightHolder";
			string label = "";
			GetLabel(out label, "CopyrightHolder", typeof(CopyrightHolder_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{201,193};
		}
	}
}