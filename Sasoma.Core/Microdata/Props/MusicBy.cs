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
	/// The composer of the movie or TV soundtrack.
	/// </summary>
	public class MusicBy_Core : PropertyCore
	{
		public MusicBy_Core()
		{
			this._PropertyId = 141;
			this._Id = "musicBy";
			string label = "";
			GetLabel(out label, "MusicBy", typeof(MusicBy_Core));
			this._Label = label;
			this._Domains = new int[]{256,169,258};
			this._Ranges = new int[]{201,176};
		}
	}
}