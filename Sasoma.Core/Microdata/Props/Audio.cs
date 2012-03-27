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
	/// An embedded audio object.
	/// </summary>
	public class Audio_Core : PropertyCore
	{
		public Audio_Core()
		{
			this._PropertyId = 20;
			this._Id = "audio";
			string label = "";
			GetLabel(out label, "Audio", typeof(Audio_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{22};
		}
	}
}