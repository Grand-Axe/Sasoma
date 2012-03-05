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
	/// A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.
	/// </summary>
	public class Circle_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 45;
			}
		}

		public string Id
		{
			get
			{
				return "circle";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Circle", typeof(Circle_Core));
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