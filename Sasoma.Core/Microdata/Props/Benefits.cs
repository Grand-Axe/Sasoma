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
	/// Description of benefits associated with the job.
	/// </summary>
	public class Benefits_Core : PropertyCore
	{
		public Benefits_Core()
		{
			this._PropertyId = 28;
			this._Id = "benefits";
			string label = "";
			GetLabel(out label, "Benefits", typeof(Benefits_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{6};
		}
	}
}