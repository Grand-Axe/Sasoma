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
	/// A link to the page containing the comments of the CreativeWork.
	/// </summary>
	public class DiscussionURL_Core : PropertyCore
	{
		public DiscussionURL_Core()
		{
			this._PropertyId = 70;
			this._Id = "discussionUrl";
			string label = "";
			GetLabel(out label, "DiscussionURL", typeof(DiscussionURL_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{7};
		}
	}
}