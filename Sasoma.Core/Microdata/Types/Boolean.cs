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
	/// Boolean: True or False.
	/// </summary>
	public class Boolean_Core : TypeCore, IDataType
	{
		public Boolean_Core()
		{
			this._TypeId = 0;
			this._Id = "Boolean";
			this._Schema_Org_Url = "http://schema.org/Boolean";
			string label = "";
			GetLabel(out label, "Boolean", typeof(Boolean_Core));
			this._Label = label;
			this._Ancestors = new int[]{1};
			this._Instances = new int[]{0,0};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{1};
			this._Properties = new int[0];

		}

	}
}