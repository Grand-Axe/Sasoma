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
	/// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
	/// </summary>
	public class HonorificSuffix_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 106;
			}
		}

		public string Id
		{
			get
			{
				return "honorificSuffix";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "HonorificSuffix", typeof(HonorificSuffix_Core));
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
				return new int[]{6};
			}
		}

	}
}