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
	/// The TV series to which this episode or season belongs.
	/// </summary>
	public class PartOfTVSeries_Core : PropertyCore
	{
		public PartOfTVSeries_Core()
		{
			this._PropertyId = 155;
			this._Id = "partOfTVSeries";
			string label = "";
			GetLabel(out label, "PartOfTVSeries", typeof(PartOfTVSeries_Core));
			this._Label = label;
			this._Domains = new int[]{256,257};
			this._Ranges = new int[]{258};
		}
	}
}