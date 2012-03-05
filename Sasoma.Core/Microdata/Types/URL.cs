using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Interfaces;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Types
{
	/// <summary>
	/// Data type: URL.
	/// </summary>
	public class URL_Core : TypeCore, IText
	{
		public int TypeId
		{
			get
			{
				return 7;
			}
		}

		public string Id
		{
			get
			{
				return "URL";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/URL";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "URL", typeof(URL_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{1,6};
			}
		}

		public int[] Instances
		{
			get
			{
				return new int[0];
			}
		}

		public int[] SubTypes
		{
			get
			{
				return new int[0];
			}
		}

		public int[] SuperTypes
		{
			get
			{
				return new int[]{6};
			}
		}

		public int[] Properties
		{
			get
			{
				return new int[0];
			}
		}


	}
}