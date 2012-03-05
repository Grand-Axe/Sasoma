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
	/// The postings that are part of this blog
	/// </summary>
	public class BlogPosts_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 32;
			}
		}

		public string Id
		{
			get
			{
				return "blogPosts";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "BlogPosts", typeof(BlogPosts_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{38};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{39};
			}
		}

	}
}