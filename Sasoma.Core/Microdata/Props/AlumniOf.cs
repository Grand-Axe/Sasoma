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
	/// An educational organizations that the person is an alumni of.
	/// </summary>
	public class AlumniOf_Core : PropertyCore
	{
		public AlumniOf_Core()
		{
			this._PropertyId = 14;
			this._Id = "alumniOf";
			string label = "";
			GetLabel(out label, "AlumniOf", typeof(AlumniOf_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{88};
		}
	}
}