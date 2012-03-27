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
	/// A date value in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>.
	/// </summary>
	public class Date_Core : TypeCore, IDataType
	{
		public Date_Core()
		{
			this._TypeId = 2;
			this._Id = "Date";
			this._Schema_Org_Url = "http://schema.org/Date";
			string label = "";
			GetLabel(out label, "Date", typeof(Date_Core));
			this._Label = label;
			this._Ancestors = new int[]{1};
			this._Instances = new int[0];
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{1};
			this._Properties = new int[0];

		}

	}
}