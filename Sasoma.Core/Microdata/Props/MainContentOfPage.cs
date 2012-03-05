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
	/// Indicates if this web page element is the main subject of the page.
	/// </summary>
	public class MainContentOfPage_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 133;
			}
		}

		public string Id
		{
			get
			{
				return "mainContentOfPage";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "MainContentOfPage", typeof(MainContentOfPage_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{293};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{294};
			}
		}

	}
}