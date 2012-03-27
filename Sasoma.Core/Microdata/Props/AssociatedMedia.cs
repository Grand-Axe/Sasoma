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
	/// The media objects that encode this creative work. This property is a synonym for encodings.
	/// </summary>
	public class AssociatedMedia_Core : PropertyCore
	{
		public AssociatedMedia_Core()
		{
			this._PropertyId = 18;
			this._Id = "associatedMedia";
			string label = "";
			GetLabel(out label, "AssociatedMedia", typeof(AssociatedMedia_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{161};
		}
	}
}