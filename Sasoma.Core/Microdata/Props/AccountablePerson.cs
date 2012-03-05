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
	/// Specifies the Person that is legally accountable for the CreativeWork.
	/// </summary>
	public class AccountablePerson_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 2;
			}
		}

		public string Id
		{
			get
			{
				return "accountablePerson";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "AccountablePerson", typeof(AccountablePerson_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{78};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{201};
			}
		}

	}
}