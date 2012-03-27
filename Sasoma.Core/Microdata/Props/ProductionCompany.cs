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
	/// The production company or studio that made the movie, TV series, season, or episode, or video.
	/// </summary>
	public class ProductionCompany_Core : PropertyCore
	{
		public ProductionCompany_Core()
		{
			this._PropertyId = 176;
			this._Id = "productionCompany";
			string label = "";
			GetLabel(out label, "ProductionCompany", typeof(ProductionCompany_Core));
			this._Label = label;
			this._Domains = new int[]{256,169,285,258};
			this._Ranges = new int[]{193};
		}
	}
}