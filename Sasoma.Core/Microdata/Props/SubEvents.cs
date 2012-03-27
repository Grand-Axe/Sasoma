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
	/// Events that are a part of this event. For example, a conference event includes many presentations, each are subEvents of the conference.
	/// </summary>
	public class SubEvents_Core : PropertyCore
	{
		public SubEvents_Core()
		{
			this._PropertyId = 216;
			this._Id = "subEvents";
			string label = "";
			GetLabel(out label, "SubEvents", typeof(SubEvents_Core));
			this._Label = label;
			this._Domains = new int[]{98};
			this._Ranges = new int[]{98};
		}
	}
}