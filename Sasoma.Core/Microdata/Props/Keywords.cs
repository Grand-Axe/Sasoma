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
	/// The keywords/tags used to describe this content.
	/// </summary>
	public class Keywords_Core : PropertyCore
	{
		public Keywords_Core()
		{
			this._PropertyId = 126;
			this._Id = "keywords";
			string label = "";
			GetLabel(out label, "Keywords", typeof(Keywords_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{6};
		}
	}
}