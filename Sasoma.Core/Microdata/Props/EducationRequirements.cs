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
	/// Educational background needed for the position.
	/// </summary>
	public class EducationRequirements_Core : PropertyCore
	{
		public EducationRequirements_Core()
		{
			this._PropertyId = 73;
			this._Id = "educationRequirements";
			string label = "";
			GetLabel(out label, "EducationRequirements", typeof(EducationRequirements_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{6};
		}
	}
}