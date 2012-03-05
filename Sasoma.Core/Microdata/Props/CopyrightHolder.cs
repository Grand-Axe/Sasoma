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
	/// The party holding the legal copyright to the CreativeWork.
	/// </summary>
	public class CopyrightHolder_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 57;
			}
		}

		public string Id
		{
			get
			{
				return "copyrightHolder";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "CopyrightHolder", typeof(CopyrightHolder_Core));
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