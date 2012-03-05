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
	/// Either <code>Yes/No</code>, or a URL at which reservations can be made.
	/// </summary>
	public class AcceptsReservations_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 1;
			}
		}

		public string Id
		{
			get
			{
				return "acceptsReservations";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "AcceptsReservations", typeof(AcceptsReservations_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{106};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{6,7};
			}
		}

	}
}