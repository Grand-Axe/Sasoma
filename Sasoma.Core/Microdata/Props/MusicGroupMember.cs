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
	/// A member of the music group\u2014for example, John, Paul, George, or Ringo.
	/// </summary>
	public class MusicGroupMember_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 142;
			}
		}

		public string Id
		{
			get
			{
				return "musicGroupMember";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "MusicGroupMember", typeof(MusicGroupMember_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{176};
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