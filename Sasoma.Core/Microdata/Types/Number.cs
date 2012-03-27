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
	/// Data type: Number.
	/// </summary>
	public class Number_Core : TypeCore, IDataType
	{
		public Number_Core()
		{
			this._TypeId = 5;
			this._Id = "Number";
			this._Schema_Org_Url = "http://schema.org/Number";
			string label = "";
			GetLabel(out label, "Number", typeof(Number_Core));
			this._Label = label;
			this._Ancestors = new int[]{1};
			this._Instances = new int[0];
			this._SubTypes = new int[]{3,4};
			this._SuperTypes = new int[]{1};
			this._Properties = new int[0];

		}

	}
}