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
	/// The producer of the movie, TV series, season, or episode, or video.
	/// </summary>
	public class Producer_Core : PropertyCore
	{
		public Producer_Core()
		{
			this._PropertyId = 174;
			this._Id = "producer";
			string label = "";
			GetLabel(out label, "Producer", typeof(Producer_Core));
			this._Label = label;
			this._Domains = new int[]{256,169,258};
			this._Ranges = new int[]{201};
		}
	}
}