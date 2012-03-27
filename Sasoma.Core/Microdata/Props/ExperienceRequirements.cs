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
	/// Description of skills and experience needed for the position.
	/// </summary>
	public class ExperienceRequirements_Core : PropertyCore
	{
		public ExperienceRequirements_Core()
		{
			this._PropertyId = 87;
			this._Id = "experienceRequirements";
			string label = "";
			GetLabel(out label, "ExperienceRequirements", typeof(ExperienceRequirements_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{6};
		}
	}
}