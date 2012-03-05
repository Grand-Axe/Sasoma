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
	/// The time at which the UserComment was made.
	/// </summary>
	public class CommentTime_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 23;
			}
		}

		public string Id
		{
			get
			{
				return "commentTime";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "CommentTime", typeof(CommentTime_Core));
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
				return new int[]{2};
			}
		}

	}
}