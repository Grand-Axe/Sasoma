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
	/// An educational organizations that the person is an alumni of.
	/// </summary>
	public class AlumniOf_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 14;
			}
		}

		public string Id
		{
			get
			{
				return "alumniOf";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "AlumniOf", typeof(AlumniOf_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{201};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{88};
			}
		}

	}
}