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
	/// Specifies the CreativeWork associated with the UserComment.
	/// </summary>
	public class Discusses_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 69;
			}
		}

		public string Id
		{
			get
			{
				return "discusses";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Discusses", typeof(Discusses_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{275};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{78};
			}
		}

	}
}