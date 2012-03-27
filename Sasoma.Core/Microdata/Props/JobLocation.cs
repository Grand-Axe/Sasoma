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
	/// A (typically single) geographic location associated with the job position.
	/// </summary>
	public class JobLocation_Core : PropertyCore
	{
		public JobLocation_Core()
		{
			this._PropertyId = 124;
			this._Id = "jobLocation";
			string label = "";
			GetLabel(out label, "JobLocation", typeof(JobLocation_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{206};
		}
	}
}