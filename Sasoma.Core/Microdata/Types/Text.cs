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
	/// Data type: Text.
	/// </summary>
	public class Text_Core : TypeCore, IDataType
	{
		public Text_Core()
		{
			this._TypeId = 6;
			this._Id = "Text";
			this._Schema_Org_Url = "http://schema.org/Text";
			string label = "";
			GetLabel(out label, "Text", typeof(Text_Core));
			this._Label = label;
			this._Ancestors = new int[]{1};
			this._Instances = new int[0];
			this._SubTypes = new int[]{7};
			this._SuperTypes = new int[]{1};
			this._Properties = new int[0];

		}

	}
}