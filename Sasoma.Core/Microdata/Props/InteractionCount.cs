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
	/// A count of a specific user interactions with this item\u2014for example, <code>20 UserLikes</code>, <code>5 UserComments</code>, or <code>300 UserDownloads</code>. The user interaction type should be one of the sub types of <a href=\http://schema.org/UserInteraction\>UserInteraction</a>.
	/// </summary>
	public class InteractionCount_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 115;
			}
		}

		public string Id
		{
			get
			{
				return "interactionCount";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "InteractionCount", typeof(InteractionCount_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{193,206,201,78};
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