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
	/// The Organization on whose behalf the creator was working.
	/// </summary>
	public class SourceOrganization_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 211;
			}
		}

		public string Id
		{
			get
			{
				return "sourceOrganization";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "SourceOrganization", typeof(SourceOrganization_Core));
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
				return new int[]{193};
			}
		}

	}
}