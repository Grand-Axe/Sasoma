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
	/// A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
	/// </summary>
	public class Line_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 129;
			}
		}

		public string Id
		{
			get
			{
				return "line";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Line", typeof(Line_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{114};
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