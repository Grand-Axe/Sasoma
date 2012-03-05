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
	/// A link to the page containing the comments of the CreativeWork.
	/// </summary>
	public class DiscussionURL_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 70;
			}
		}

		public string Id
		{
			get
			{
				return "discussionUrl";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "DiscussionURL", typeof(DiscussionURL_Core));
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
				return new int[]{7};
			}
		}

	}
}