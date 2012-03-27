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
	/// A NewsArticle associated with the Media Object.
	/// </summary>
	public class AssociatedArticle_Core : PropertyCore
	{
		public AssociatedArticle_Core()
		{
			this._PropertyId = 17;
			this._Id = "associatedArticle";
			string label = "";
			GetLabel(out label, "AssociatedArticle", typeof(AssociatedArticle_Core));
			this._Label = label;
			this._Domains = new int[]{161};
			this._Ranges = new int[]{184};
		}
	}
}