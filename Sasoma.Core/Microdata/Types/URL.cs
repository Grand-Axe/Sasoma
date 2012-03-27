using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Microdata.Interfaces;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Types
{
	/// <summary>
	/// Data type: URL.
	/// </summary>
	public class URL_Core : TypeCore, IText
	{
		public URL_Core()
		{
			this._TypeId = 7;
			this._Id = "URL";
			this._Schema_Org_Url = "http://schema.org/URL";
			string label = "";
			GetLabel(out label, "URL", typeof(URL_Core));
			this._Label = label;
			this._Ancestors = new int[]{1,6};
			this._Instances = new int[0];
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{6};
			this._Properties = new int[0];

		}

	}
}