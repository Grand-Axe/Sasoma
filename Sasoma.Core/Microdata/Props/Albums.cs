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
	/// A collection of music albums.
	/// </summary>
	public class Albums_Core : PropertyCore
	{
		public Albums_Core()
		{
			this._PropertyId = 11;
			this._Id = "albums";
			string label = "";
			GetLabel(out label, "Albums", typeof(Albums_Core));
			this._Label = label;
			this._Domains = new int[]{176};
			this._Ranges = new int[]{174};
		}
	}
}