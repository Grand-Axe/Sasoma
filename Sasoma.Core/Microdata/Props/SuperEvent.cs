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
	/// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
	/// </summary>
	public class SuperEvent_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 218;
			}
		}

		public string Id
		{
			get
			{
				return "superEvent";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "SuperEvent", typeof(SuperEvent_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{98};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{98};
			}
		}

	}
}