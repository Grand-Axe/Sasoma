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
	/// Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes textual label and formal code, with the property repeated for each applicable value.
	/// </summary>
	public class OccupationalCategory_Core : PropertyCore
	{
		public OccupationalCategory_Core()
		{
			this._PropertyId = 149;
			this._Id = "occupationalCategory";
			string label = "";
			GetLabel(out label, "OccupationalCategory", typeof(OccupationalCategory_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{6};
		}
	}
}