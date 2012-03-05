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
	/// Link to page describing the editorial principles of the organization primarily responsible for the creation of the CreativeWork.
	/// </summary>
	public class PublishingPrinciples_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 180;
			}
		}

		public string Id
		{
			get
			{
				return "publishingPrinciples";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PublishingPrinciples", typeof(PublishingPrinciples_Core));
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
				return new int[]{7};
			}
		}

	}
}