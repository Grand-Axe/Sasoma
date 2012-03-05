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
	/// Events that are a part of this event. For example, a conference event includes many presentations, each are subEvents of the conference.
	/// </summary>
	public class SubEvents_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 216;
			}
		}

		public string Id
		{
			get
			{
				return "subEvents";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "SubEvents", typeof(SubEvents_Core));
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