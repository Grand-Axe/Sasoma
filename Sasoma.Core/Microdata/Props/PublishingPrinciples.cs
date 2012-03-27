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
	/// Link to page describing the editorial principles of the organization primarily responsible for the creation of the CreativeWork.
	/// </summary>
	public class PublishingPrinciples_Core : PropertyCore
	{
		public PublishingPrinciples_Core()
		{
			this._PropertyId = 180;
			this._Id = "publishingPrinciples";
			string label = "";
			GetLabel(out label, "PublishingPrinciples", typeof(PublishingPrinciples_Core));
			this._Label = label;
			this._Domains = new int[]{78};
			this._Ranges = new int[]{7};
		}
	}
}