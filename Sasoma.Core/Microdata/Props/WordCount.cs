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
	/// The number of words in the text of the Article.
	/// </summary>
	public class WordCount_Core : PropertyCore
	{
		public WordCount_Core()
		{
			this._PropertyId = 235;
			this._Id = "wordCount";
			string label = "";
			GetLabel(out label, "WordCount", typeof(WordCount_Core));
			this._Label = label;
			this._Domains = new int[]{20};
			this._Ranges = new int[]{4};
		}
	}
}