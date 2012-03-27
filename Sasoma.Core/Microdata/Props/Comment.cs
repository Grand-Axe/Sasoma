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
	/// Comments, typically from users, on this CreativeWork.
	/// </summary>
	public class Comment_Core : PropertyCore
	{
		public Comment_Core()
		{
			this._PropertyId = 21;
			this._Id = "comment";
			string label = "";
			GetLabel(out label, "Comment", typeof(Comment_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{275};
		}
	}
}