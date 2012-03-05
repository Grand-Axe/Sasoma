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
	/// A NewsArticle associated with the Media Object.
	/// </summary>
	public class AssociatedArticle_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 17;
			}
		}

		public string Id
		{
			get
			{
				return "associatedArticle";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "AssociatedArticle", typeof(AssociatedArticle_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{161};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{184};
			}
		}

	}
}