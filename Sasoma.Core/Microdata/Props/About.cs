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
	/// The subject matter of the content.
	/// </summary>
	public class About_Core : PropertyCore
	{
		public About_Core()
		{
			this._PropertyId = 0;
			this._Id = "about";
			string label = "";
			GetLabel(out label, "About", typeof(About_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{266};
		}
	}
}