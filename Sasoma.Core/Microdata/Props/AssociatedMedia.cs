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
	/// The media objects that encode this creative work. This property is a synonym for encodings.
	/// </summary>
	public class AssociatedMedia_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 18;
			}
		}

		public string Id
		{
			get
			{
				return "associatedMedia";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "AssociatedMedia", typeof(AssociatedMedia_Core));
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
				return new int[]{161};
			}
		}

	}
}