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
	/// The height of the media object.
	/// </summary>
	public class Height_Core : PropertyCore
	{
		public Height_Core()
		{
			this._PropertyId = 101;
			this._Id = "height";
			string label = "";
			GetLabel(out label, "Height", typeof(Height_Core));
			this._Label = label;
			this._Domains = new int[]{161};
			this._Ranges = new int[]{76};
		}
	}
}