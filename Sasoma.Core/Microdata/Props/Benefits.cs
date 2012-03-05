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
	/// Description of benefits associated with the job.
	/// </summary>
	public class Benefits_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 28;
			}
		}

		public string Id
		{
			get
			{
				return "benefits";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Benefits", typeof(Benefits_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{144};
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