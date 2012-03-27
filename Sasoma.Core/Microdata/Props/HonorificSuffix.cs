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
	/// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
	/// </summary>
	public class HonorificSuffix_Core : PropertyCore
	{
		public HonorificSuffix_Core()
		{
			this._PropertyId = 106;
			this._Id = "honorificSuffix";
			string label = "";
			GetLabel(out label, "HonorificSuffix", typeof(HonorificSuffix_Core));
			this._Label = label;
			this._Domains = new int[]{201};
			this._Ranges = new int[]{6};
		}
	}
}