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
	/// An organization to which the person belongs.
	/// </summary>
	public class MemberOf_Core : PropertyCore
	{
		public MemberOf_Core()
		{
			this._PropertyId = 136;
			this._Id = "memberOf";
			string label = "";
			GetLabel(out label, "MemberOf", typeof(MemberOf_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{193};
		}
	}
}