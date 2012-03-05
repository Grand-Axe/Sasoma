using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Interfaces;

namespace Sasoma.Microdata.Properties
{
	/// <summary>
	/// Cash, credit card, etc.
	/// </summary>
	public class PaymentAccepted_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 156;
			}
		}

		public string Id
		{
			get
			{
				return "paymentAccepted";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PaymentAccepted", typeof(PaymentAccepted_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{155};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{6};
			}
		}

	}
}