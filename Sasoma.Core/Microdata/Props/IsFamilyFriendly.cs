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
	/// Indicates whether this content is family friendly.
	/// </summary>
	public class IsFamilyFriendly_Core : PropertyCore
	{
		public IsFamilyFriendly_Core()
		{
			this._PropertyId = 116;
			this._Id = "isFamilyFriendly";
			string label = "";
			GetLabel(out label, "IsFamilyFriendly", typeof(IsFamilyFriendly_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{0};
		}
	}
}