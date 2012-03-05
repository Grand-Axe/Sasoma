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
	/// Specifies the Person who edited the CreativeWork.
	/// </summary>
	public class Editor_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 72;
			}
		}

		public string Id
		{
			get
			{
				return "editor";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Editor", typeof(Editor_Core));
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
				return new int[]{201};
			}
		}

	}
}