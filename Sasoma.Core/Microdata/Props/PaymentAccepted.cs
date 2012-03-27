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
	/// Cash, credit card, etc.
	/// </summary>
	public class PaymentAccepted_Core : PropertyCore
	{
		public PaymentAccepted_Core()
		{
			this._PropertyId = 156;
			this._Id = "paymentAccepted";
			string label = "";
			GetLabel(out label, "PaymentAccepted", typeof(PaymentAccepted_Core));
			this._Label = label;
			this._Domains = new int[]{155};
			this._Ranges = new int[]{6};
		}
	}
}