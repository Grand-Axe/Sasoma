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
	/// The creator/author of this CreativeWork or UserComments. This is the same as the Author property for CreativeWork.
	/// </summary>
	public class Creator_Core : PropertyCore
	{
		public Creator_Core()
		{
			this._PropertyId = 59;
			this._Id = "creator";
			string label = "";
			GetLabel(out label, "Creator", typeof(Creator_Core));
			this._Label = label;
			this._Domains = new int[]{275,78};
			this._Ranges = new int[]{201,193};
		}
	}
}