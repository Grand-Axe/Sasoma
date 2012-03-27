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
	/// Organization offering the job position.
	/// </summary>
	public class HiringOrganization_Core : PropertyCore
	{
		public HiringOrganization_Core()
		{
			this._PropertyId = 103;
			this._Id = "hiringOrganization";
			string label = "";
			GetLabel(out label, "HiringOrganization", typeof(HiringOrganization_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{193};
		}
	}
}