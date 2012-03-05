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
	/// Player type required\u2014for example, Flash or Silverlight.
	/// </summary>
	public class PlayerType_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 160;
			}
		}

		public string Id
		{
			get
			{
				return "playerType";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PlayerType", typeof(PlayerType_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{161};
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