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
	/// A contact point for a person or organization.
	/// </summary>
	public class ContactPoints_Core : PropertyCore
	{
		public ContactPoints_Core()
		{
			this._PropertyId = 47;
			this._Id = "contactPoints";
			string label = "";
			GetLabel(out label, "ContactPoints", typeof(ContactPoints_Core));
			this._Label = label;
			this._Domains = new int[]{193,201};
			this._Ranges = new int[]{70};
		}
	}
}