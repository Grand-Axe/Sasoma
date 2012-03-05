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
	/// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
	/// </summary>
	public class ContactType_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 48;
			}
		}

		public string Id
		{
			get
			{
				return "contactType";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ContactType", typeof(ContactType_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{70};
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