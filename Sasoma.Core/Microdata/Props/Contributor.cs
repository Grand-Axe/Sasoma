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
	/// A secondary contributor to the CreativeWork.
	/// </summary>
	public class Contributor_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 54;
			}
		}

		public string Id
		{
			get
			{
				return "contributor";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Contributor", typeof(Contributor_Core));
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
				return new int[]{201,193};
			}
		}

	}
}