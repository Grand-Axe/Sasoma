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
	/// The language of the content. please use one of the language codes from the <a href=\http://tools.ietf.org/html/bcp47\>IETF BCP 47 standard.</a>
	/// </summary>
	public class InLanguage_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 110;
			}
		}

		public string Id
		{
			get
			{
				return "inLanguage";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "InLanguage", typeof(InLanguage_Core));
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
				return new int[]{6};
			}
		}

	}
}