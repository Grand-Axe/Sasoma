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
	/// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
	/// </summary>
	public class SuperEvent_Core : PropertyCore
	{
		public SuperEvent_Core()
		{
			this._PropertyId = 218;
			this._Id = "superEvent";
			string label = "";
			GetLabel(out label, "SuperEvent", typeof(SuperEvent_Core));
			this._Label = label;
			this._Domains = new int[]{98};
			this._Ranges = new int[]{98};
		}
	}
}