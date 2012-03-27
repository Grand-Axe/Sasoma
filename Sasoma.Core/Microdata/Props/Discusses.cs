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
	/// Specifies the CreativeWork associated with the UserComment.
	/// </summary>
	public class Discusses_Core : PropertyCore
	{
		public Discusses_Core()
		{
			this._PropertyId = 69;
			this._Id = "discusses";
			string label = "";
			GetLabel(out label, "Discusses", typeof(Discusses_Core));
			this._Label = label;
			this._Domains = new int[]{275};
			this._Ranges = new int[]{78};
		}
	}
}