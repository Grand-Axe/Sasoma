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
	/// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
	/// </summary>
	public class Transcript_Core : PropertyCore
	{
		public Transcript_Core()
		{
			this._PropertyId = 226;
			this._Id = "transcript";
			string label = "";
			GetLabel(out label, "Transcript", typeof(Transcript_Core));
			this._Label = label;
			this._Domains = new int[]{22,285};
			this._Ranges = new int[]{6};
		}
	}
}