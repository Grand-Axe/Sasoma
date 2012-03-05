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
	/// The creator/author of this CreativeWork or UserComments. This is the same as the Author property for CreativeWork.
	/// </summary>
	public class Creator_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 59;
			}
		}

		public string Id
		{
			get
			{
				return "creator";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Creator", typeof(Creator_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{275,78};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{201,193};
			}
		}

	}
}