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
	/// Indicates if use of the media require a subscription  (either paid or free). Allowed values are <code>yes</code> or <code>no</code>.
	/// </summary>
	public class RequiresSubscription_Core : PropertyCore
	{
		public RequiresSubscription_Core()
		{
			this._PropertyId = 192;
			this._Id = "requiresSubscription";
			string label = "";
			GetLabel(out label, "RequiresSubscription", typeof(RequiresSubscription_Core));
			this._Label = label;
			this._Domains = new int[]{161};
			this._Ranges = new int[]{0};
		}
	}
}