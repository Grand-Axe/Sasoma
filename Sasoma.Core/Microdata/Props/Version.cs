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
	/// The version of the CreativeWork embodied by a specified resource.
	/// </summary>
	public class Version_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 230;
			}
		}

		public string Id
		{
			get
			{
				return "version";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Version", typeof(Version_Core));
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
				return new int[]{5};
			}
		}

	}
}