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
	/// Description of bonus and commission compensation aspects of the job.
	/// </summary>
	public class Incentives_Core : PropertyCore
	{
		public Incentives_Core()
		{
			this._PropertyId = 112;
			this._Id = "incentives";
			string label = "";
			GetLabel(out label, "Incentives", typeof(Incentives_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{6};
		}
	}
}