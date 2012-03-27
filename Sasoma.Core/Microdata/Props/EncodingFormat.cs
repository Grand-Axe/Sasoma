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
	/// mp3, mpeg4, etc.
	/// </summary>
	public class EncodingFormat_Core : PropertyCore
	{
		public EncodingFormat_Core()
		{
			this._PropertyId = 80;
			this._Id = "encodingFormat";
			string label = "";
			GetLabel(out label, "EncodingFormat", typeof(EncodingFormat_Core));
			this._Label = label;
			this._Domains = new int[]{161};
			this._Ranges = new int[]{6};
		}
	}
}