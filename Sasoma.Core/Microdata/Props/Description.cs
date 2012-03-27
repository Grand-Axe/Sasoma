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
	/// A short description of the item.
	/// </summary>
	public class Description_Core : PropertyCore
	{
		public Description_Core()
		{
			this._PropertyId = 67;
			this._Id = "description";
			string label = "";
			GetLabel(out label, "Description", typeof(Description_Core));
			this._Label = label;
			this._Domains = new int[]{266};
			this._Ranges = new int[]{6};
		}
	}
}