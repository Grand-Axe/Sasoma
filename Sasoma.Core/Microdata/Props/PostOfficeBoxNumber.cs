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
	/// The post offce box number for PO box addresses.
	/// </summary>
	public class PostOfficeBoxNumber_Core : PropertyCore
	{
		public PostOfficeBoxNumber_Core()
		{
			this._PropertyId = 162;
			this._Id = "postOfficeBoxNumber";
			string label = "";
			GetLabel(out label, "PostOfficeBoxNumber", typeof(PostOfficeBoxNumber_Core));
			this._Label = label;
			this._Domains = new int[]{213};
			this._Ranges = new int[]{6};
		}
	}
}