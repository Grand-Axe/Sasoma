using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Microdata.Interfaces;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Types;

namespace Sasoma.Microdata.Properties
{
	/// <summary>
	/// A member of the music group\u2014for example, John, Paul, George, or Ringo.
	/// </summary>
	public class MusicGroupMember_Core : PropertyCore
	{
		public MusicGroupMember_Core()
		{
			this._PropertyId = 142;
			this._Id = "musicGroupMember";
			string label = "";
			GetLabel(out label, "MusicGroupMember", typeof(MusicGroupMember_Core));
			this._Label = label;
			this._Domains = new int[]{176};
			this._Ranges = new int[]{201};
		}
	}
}