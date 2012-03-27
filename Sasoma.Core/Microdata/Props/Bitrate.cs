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
	/// The bitrate of the media object.
	/// </summary>
	public class Bitrate_Core : PropertyCore
	{
		public Bitrate_Core()
		{
			this._PropertyId = 31;
			this._Id = "bitrate";
			string label = "";
			GetLabel(out label, "Bitrate", typeof(Bitrate_Core));
			this._Label = label;
			this._Domains = new int[]{161};
			this._Ranges = new int[]{6};
		}
	}
}