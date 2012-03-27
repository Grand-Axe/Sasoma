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
	/// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
	/// </summary>
	public class HonorificPrefix_Core : PropertyCore
	{
		public HonorificPrefix_Core()
		{
			this._PropertyId = 105;
			this._Id = "honorificPrefix";
			string label = "";
			GetLabel(out label, "HonorificPrefix", typeof(HonorificPrefix_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{6};
		}
	}
}