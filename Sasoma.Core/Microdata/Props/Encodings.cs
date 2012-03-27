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
	/// The media objects that encode this creative work
	/// </summary>
	public class Encodings_Core : PropertyCore
	{
		public Encodings_Core()
		{
			this._PropertyId = 81;
			this._Id = "encodings";
			string label = "";
			GetLabel(out label, "Encodings", typeof(Encodings_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{161};
		}
	}
}