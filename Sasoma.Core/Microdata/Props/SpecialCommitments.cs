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
	/// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
	/// </summary>
	public class SpecialCommitments_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 212;
			}
		}

		public string Id
		{
			get
			{
				return "specialCommitments";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "SpecialCommitments", typeof(SpecialCommitments_Core));
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