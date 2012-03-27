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
	/// Specifies the Person that is legally accountable for the CreativeWork.
	/// </summary>
	public class AccountablePerson_Core : PropertyCore
	{
		public AccountablePerson_Core()
		{
			this._PropertyId = 2;
			this._Id = "accountablePerson";
			string label = "";
			GetLabel(out label, "AccountablePerson", typeof(AccountablePerson_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{201};
		}
	}
}