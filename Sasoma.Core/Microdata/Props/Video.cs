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
	/// An embedded video object.
	/// </summary>
	public class Video_Core : PropertyCore
	{
		public Video_Core()
		{
			this._PropertyId = 231;
			this._Id = "video";
			string label = "";
			GetLabel(out label, "Video", typeof(Video_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{285};
		}
	}
}