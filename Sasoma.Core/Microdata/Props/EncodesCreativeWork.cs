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
	/// The creative work encoded by this media object
	/// </summary>
	public class EncodesCreativeWork_Core : PropertyCore
	{
		public EncodesCreativeWork_Core()
		{
			this._PropertyId = 79;
			this._Id = "encodesCreativeWork";
			string label = "";
			GetLabel(out label, "EncodesCreativeWork", typeof(EncodesCreativeWork_Core));
			this._Label = label;
			this._Domains = new int[]{161};
			this._Ranges = new int[]{78};
		}
	}
}