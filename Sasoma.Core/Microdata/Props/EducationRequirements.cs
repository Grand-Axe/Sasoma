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
	/// Educational background needed for the position.
	/// </summary>
	public class EducationRequirements_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 73;
			}
		}

		public string Id
		{
			get
			{
				return "educationRequirements";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "EducationRequirements", typeof(EducationRequirements_Core));
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