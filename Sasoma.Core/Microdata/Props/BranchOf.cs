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
	/// The larger organization that this local business is a branch of, if any.
	/// </summary>
	public class BranchOf_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 36;
			}
		}

		public string Id
		{
			get
			{
				return "branchOf";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "BranchOf", typeof(BranchOf_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{155};
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