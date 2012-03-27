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
	/// The actual body of the article.
	/// </summary>
	public class ArticleBody_Core : PropertyCore
	{
		public ArticleBody_Core()
		{
			this._PropertyId = 15;
			this._Id = "articleBody";
			string label = "";
			GetLabel(out label, "ArticleBody", typeof(ArticleBody_Core));
			this._Label = label;
			this._Domains = new int[]{20};
			this._Ranges = new int[]{6};
		}
	}
}