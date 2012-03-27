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
	/// The publisher of the creative work.
	/// </summary>
	public class Publisher_Core : PropertyCore
	{
		public Publisher_Core()
		{
			this._PropertyId = 179;
			this._Id = "publisher";
			string label = "";
			GetLabel(out label, "Publisher", typeof(Publisher_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{193};
		}
	}
}