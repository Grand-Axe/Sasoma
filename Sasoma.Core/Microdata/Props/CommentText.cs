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
	/// The text of the UserComment.
	/// </summary>
	public class CommentText_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 22;
			}
		}

		public string Id
		{
			get
			{
				return "commentText";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "CommentText", typeof(CommentText_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{275};
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