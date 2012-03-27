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
	/// The author of this content. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangabely.
	/// </summary>
	public class Author_Core : PropertyCore
	{
		public Author_Core()
		{
			this._PropertyId = 24;
			this._Id = "author";
			string label = "";
			GetLabel(out label, "Author", typeof(Author_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{201,193};
		}
	}
}