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
	/// The model of the product.
	/// </summary>
	public class Model_Core : PropertyCore
	{
		public Model_Core()
		{
			this._PropertyId = 140;
			this._Id = "model";
			string label = "";
			GetLabel(out label, "Model", typeof(Model_Core));
			this._Label = label;
			this._Domains = new int[]{215};
			this._Ranges = new int[]{6};
		}
	}
}