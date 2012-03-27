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
	/// The version of the CreativeWork embodied by a specified resource.
	/// </summary>
	public class Version_Core : PropertyCore
	{
		public Version_Core()
		{
			this._PropertyId = 230;
			this._Id = "version";
			string label = "";
			GetLabel(out label, "Version", typeof(Version_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{5};
		}
	}
}