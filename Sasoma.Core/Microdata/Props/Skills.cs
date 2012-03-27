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
	/// Skills required to fulfill this role.
	/// </summary>
	public class Skills_Core : PropertyCore
	{
		public Skills_Core()
		{
			this._PropertyId = 209;
			this._Id = "skills";
			string label = "";
			GetLabel(out label, "Skills", typeof(Skills_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{6};
		}
	}
}