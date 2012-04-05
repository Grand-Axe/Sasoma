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
	/// The basic data types such as Integers, Strings, etc.
	/// </summary>
    public class DataType_Core : TypeCore, IDataType
	{
		public DataType_Core()
		{
			this._TypeId = 1;
			this._Id = "DataType";
			this._Schema_Org_Url = "http://schema.org/DataType";
			string label = "";
			GetLabel(out label, "DataType", typeof(DataType_Core));
			this._Label = label;
			this._Ancestors = new int[0];
			this._SubTypes = new int[]{0,2,5,6};
			this._SuperTypes = new int[0];
			this._Properties = new int[0];

		}

	}
}