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
	/// The job title of the person (for example, Financial Manager).
	/// </summary>
	public class JobTitle_Core : PropertyCore
	{
		public JobTitle_Core()
		{
			this._PropertyId = 125;
			this._Id = "jobTitle";
			string label = "";
			GetLabel(out label, "JobTitle", typeof(JobTitle_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{6};
		}
	}
}