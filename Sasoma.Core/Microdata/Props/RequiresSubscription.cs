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
	/// Indicates if use of the media require a subscription  (either paid or free). Allowed values are <code>yes</code> or <code>no</code>.
	/// </summary>
	public class RequiresSubscription_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 192;
			}
		}

		public string Id
		{
			get
			{
				return "requiresSubscription";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "RequiresSubscription", typeof(RequiresSubscription_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{161};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{0};
			}
		}

	}
}