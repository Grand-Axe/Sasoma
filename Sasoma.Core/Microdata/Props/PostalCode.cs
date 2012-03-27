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
	/// The postal code. For example, 94043.
	/// </summary>
	public class PostalCode_Core : PropertyCore
	{
		public PostalCode_Core()
		{
			this._PropertyId = 163;
			this._Id = "postalCode";
			string label = "";
			GetLabel(out label, "PostalCode", typeof(PostalCode_Core));
			this._Label = label;
			this._Domains = new int[]{213};
			this._Ranges = new int[]{6};
		}
	}
}