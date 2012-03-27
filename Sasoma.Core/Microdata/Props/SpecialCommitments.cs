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
	/// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
	/// </summary>
	public class SpecialCommitments_Core : PropertyCore
	{
		public SpecialCommitments_Core()
		{
			this._PropertyId = 212;
			this._Id = "specialCommitments";
			string label = "";
			GetLabel(out label, "SpecialCommitments", typeof(SpecialCommitments_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{6};
		}
	}
}