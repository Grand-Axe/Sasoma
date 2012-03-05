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
	/// Description of bonus and commission compensation aspects of the job.
	/// </summary>
	public class Incentives_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 112;
			}
		}

		public string Id
		{
			get
			{
				return "incentives";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Incentives", typeof(Incentives_Core));
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