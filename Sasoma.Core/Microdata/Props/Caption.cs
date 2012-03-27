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
	/// The caption for this object.
	/// </summary>
	public class Caption_Core : PropertyCore
	{
		public Caption_Core()
		{
			this._PropertyId = 41;
			this._Id = "caption";
			string label = "";
			GetLabel(out label, "Caption", typeof(Caption_Core));
			this._Label = label;
			this._Domains = new int[]{285,136};
			this._Ranges = new int[]{6};
		}
	}
}