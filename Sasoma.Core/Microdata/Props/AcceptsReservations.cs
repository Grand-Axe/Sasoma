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
	/// Either <code>Yes/No</code>, or a URL at which reservations can be made.
	/// </summary>
	public class AcceptsReservations_Core : PropertyCore
	{
		public AcceptsReservations_Core()
		{
			this._PropertyId = 1;
			this._Id = "acceptsReservations";
			string label = "";
			GetLabel(out label, "AcceptsReservations", typeof(AcceptsReservations_Core));
			this._Label = label;
			this._Domains = new int[]{106};
			this._Ranges = new int[]{6,7};
		}
	}
}