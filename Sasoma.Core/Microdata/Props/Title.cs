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
	/// The title of the job.
	/// </summary>
	public class Title_Core : PropertyCore
	{
		public Title_Core()
		{
			this._PropertyId = 221;
			this._Id = "title";
			string label = "";
			GetLabel(out label, "Title", typeof(Title_Core));
			this._Label = label;
			this._Domains = new int[]{144};
			this._Ranges = new int[]{6};
		}
	}
}