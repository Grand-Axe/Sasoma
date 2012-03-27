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
	/// Data type: Floating number.
	/// </summary>
	public class Float_Core : TypeCore, INumber
	{
		public Float_Core()
		{
			this._TypeId = 3;
			this._Id = "Float";
			this._Schema_Org_Url = "http://schema.org/Float";
			string label = "";
			GetLabel(out label, "Float", typeof(Float_Core));
			this._Label = label;
			this._Ancestors = new int[]{1,5};
			this._Instances = new int[0];
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{5};
			this._Properties = new int[0];

		}

	}
}