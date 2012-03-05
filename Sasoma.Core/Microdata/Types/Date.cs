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
	/// A date value in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>.
	/// </summary>
	public class Date_Core : TypeCore, IDataType
	{
		public int TypeId
		{
			get
			{
				return 2;
			}
		}

		public string Id
		{
			get
			{
				return "Date";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/Date";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Date", typeof(Date_Core));
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
				return new int[0];
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