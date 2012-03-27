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
	/// A secondary title of the CreativeWork.
	/// </summary>
	public class AlternativeHeadline_Core : PropertyCore
	{
		public AlternativeHeadline_Core()
		{
			this._PropertyId = 12;
			this._Id = "alternativeHeadline";
			string label = "";
			GetLabel(out label, "AlternativeHeadline", typeof(AlternativeHeadline_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{6};
		}
	}
}