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
	/// The larger organization that this local business is a branch of, if any.
	/// </summary>
	public class BranchOf_Core : PropertyCore
	{
		public BranchOf_Core()
		{
			this._PropertyId = 36;
			this._Id = "branchOf";
			string label = "";
			GetLabel(out label, "BranchOf", typeof(BranchOf_Core));
			this._Label = label;
			this._Domains = new int[]{155};
			this._Ranges = new int[]{193};
		}
	}
}