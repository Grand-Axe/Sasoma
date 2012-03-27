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
	/// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
	/// </summary>
	public class Mentions_Core : PropertyCore
	{
		public Mentions_Core()
		{
			this._PropertyId = 138;
			this._Id = "mentions";
			string label = "";
			GetLabel(out label, "Mentions", typeof(Mentions_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{266};
		}
	}
}