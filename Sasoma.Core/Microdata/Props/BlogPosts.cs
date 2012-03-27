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
	/// The postings that are part of this blog
	/// </summary>
	public class BlogPosts_Core : PropertyCore
	{
		public BlogPosts_Core()
		{
			this._PropertyId = 32;
			this._Id = "blogPosts";
			string label = "";
			GetLabel(out label, "BlogPosts", typeof(BlogPosts_Core));
			this._Label = label;
			this._Domains = new int[]{38};
			this._Ranges = new int[]{39};
		}
	}
}