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
	/// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
	/// </summary>
	public class Transcript_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 226;
			}
		}

		public string Id
		{
			get
			{
				return "transcript";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Transcript", typeof(Transcript_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{22,285};
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