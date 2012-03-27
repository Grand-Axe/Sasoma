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
	/// Specifies the Person who edited the CreativeWork.
	/// </summary>
	public class Editor_Core : PropertyCore
	{
		public Editor_Core()
		{
			this._PropertyId = 72;
			this._Id = "editor";
			string label = "";
			GetLabel(out label, "Editor", typeof(Editor_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{201};
		}
	}
}