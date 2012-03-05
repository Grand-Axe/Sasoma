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
	/// Data type: Text.
	/// </summary>
	public class Text_Core : TypeCore, IDataType
	{
		public int TypeId
		{
			get
			{
				return 6;
			}
		}

		public string Id
		{
			get
			{
				return "Text";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/Text";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Text", typeof(Text_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{1};
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
				return new int[]{7};
			}
		}

		public int[] SuperTypes
		{
			get
			{
				return new int[]{1};
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