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
	/// The text of the UserComment.
	/// </summary>
	public class CommentText_Core : PropertyCore
	{
		public CommentText_Core()
		{
			this._PropertyId = 22;
			this._Id = "commentText";
			string label = "";
			GetLabel(out label, "CommentText", typeof(CommentText_Core));
			this._Label = label;
			this._Domains = new int[]{275};
			this._Ranges = new int[]{6};
		}
	}
}