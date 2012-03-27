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
	/// The time at which the UserComment was made.
	/// </summary>
	public class CommentTime_Core : PropertyCore
	{
		public CommentTime_Core()
		{
			this._PropertyId = 23;
			this._Id = "commentTime";
			string label = "";
			GetLabel(out label, "CommentTime", typeof(CommentTime_Core));
			this._Label = label;
			this._Domains = new int[]{275};
			this._Ranges = new int[]{2};
		}
	}
}