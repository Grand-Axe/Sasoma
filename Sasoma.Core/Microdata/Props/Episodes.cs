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
	/// The episode of a TV series or season.
	/// </summary>
	public class Episodes_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 84;
			}
		}

		public string Id
		{
			get
			{
				return "episodes";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Episodes", typeof(Episodes_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{257,258};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{256};
			}
		}

	}
}