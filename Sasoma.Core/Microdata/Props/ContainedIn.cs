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
	/// The basic containment relation between places.
	/// </summary>
	public class ContainedIn_Core : PropertyCore
	{
		public ContainedIn_Core()
		{
			this._PropertyId = 49;
			this._Id = "containedIn";
			string label = "";
			GetLabel(out label, "ContainedIn", typeof(ContainedIn_Core));
			this._Label = label;
			this._Domains = new int[]{206};
			this._Ranges = new int[]{206};
		}
	}
}