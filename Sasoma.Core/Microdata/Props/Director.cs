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
	/// The director of the movie, TV episode, or series.
	/// </summary>
	public class Director_Core : PropertyCore
	{
		public Director_Core()
		{
			this._PropertyId = 68;
			this._Id = "director";
			string label = "";
			GetLabel(out label, "Director", typeof(Director_Core));
			this._Label = label;
			this._Domains = new int[]{256,169,258};
			this._Ranges = new int[]{201};
		}
	}
}