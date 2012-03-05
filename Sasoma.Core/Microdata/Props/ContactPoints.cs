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
	/// A contact point for a person or organization.
	/// </summary>
	public class ContactPoints_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 47;
			}
		}

		public string Id
		{
			get
			{
				return "contactPoints";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ContactPoints", typeof(ContactPoints_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{193,201};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{70};
			}
		}

	}
}