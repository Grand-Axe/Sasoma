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
	/// Data type: Integer.
	/// </summary>
	public class Integer_Core : TypeCore, INumber
	{
		public Integer_Core()
		{
			this._TypeId = 4;
			this._Id = "Integer";
			this._Schema_Org_Url = "http://schema.org/Integer";
			string label = "";
			GetLabel(out label, "Integer", typeof(Integer_Core));
			this._Label = label;
			this._Ancestors = new int[]{1,5};
			this._Instances = new int[0];
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{5};
			this._Properties = new int[0];

		}

	}
}