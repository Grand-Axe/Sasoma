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
	/// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
	/// </summary>
	public class ContactType_Core : PropertyCore
	{
		public ContactType_Core()
		{
			this._PropertyId = 48;
			this._Id = "contactType";
			string label = "";
			GetLabel(out label, "ContactType", typeof(ContactType_Core));
			this._Label = label;
			this._Domains = new int[]{70};
			this._Ranges = new int[]{6};
		}
	}
}