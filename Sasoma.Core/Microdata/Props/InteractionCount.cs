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
	/// A count of a specific user interactions with this item\u2014for example, <code>20 UserLikes</code>, <code>5 UserComments</code>, or <code>300 UserDownloads</code>. The user interaction type should be one of the sub types of <a href=\http://schema.org/UserInteraction\>UserInteraction</a>.
	/// </summary>
	public class InteractionCount_Core : PropertyCore
	{
		public InteractionCount_Core()
		{
			this._PropertyId = 115;
			this._Id = "interactionCount";
			string label = "";
			GetLabel(out label, "InteractionCount", typeof(InteractionCount_Core));
			this._Label = label;
			this._Domains = new int[]{193,206,201,78};
			this._Ranges = new int[]{6};
		}
	}
}