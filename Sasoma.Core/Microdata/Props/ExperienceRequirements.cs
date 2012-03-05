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
	/// Description of skills and experience needed for the position.
	/// </summary>
	public class ExperienceRequirements_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 87;
			}
		}

		public string Id
		{
			get
			{
				return "experienceRequirements";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ExperienceRequirements", typeof(ExperienceRequirements_Core));
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