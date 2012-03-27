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
	/// Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
	/// </summary>
	public class ArticleSection_Core : PropertyCore
	{
		public ArticleSection_Core()
		{
			this._PropertyId = 16;
			this._Id = "articleSection";
			string label = "";
			GetLabel(out label, "ArticleSection", typeof(ArticleSection_Core));
			this._Label = label;
			this._Domains = new int[]{20};
			this._Ranges = new int[]{6};
		}
	}
}