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
	/// The Organization on whose behalf the creator was working.
	/// </summary>
	public class SourceOrganization_Core : PropertyCore
	{
		public SourceOrganization_Core()
		{
			this._PropertyId = 211;
			this._Id = "sourceOrganization";
			string label = "";
			GetLabel(out label, "SourceOrganization", typeof(SourceOrganization_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{193};
		}
	}
}