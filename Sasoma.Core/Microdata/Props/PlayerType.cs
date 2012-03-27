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
	/// Player type required\u2014for example, Flash or Silverlight.
	/// </summary>
	public class PlayerType_Core : PropertyCore
	{
		public PlayerType_Core()
		{
			this._PropertyId = 160;
			this._Id = "playerType";
			string label = "";
			GetLabel(out label, "PlayerType", typeof(PlayerType_Core));
			this._Label = label;
			this._Domains = new int[]{161};
			this._Ranges = new int[]{6};
		}
	}
}